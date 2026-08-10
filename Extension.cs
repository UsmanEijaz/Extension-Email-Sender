using System;
using System.Net.Mail;
using System.Net;
using OutSystems.HubEdition.RuntimePlatform;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using OutSystems.RuntimeCommon;
using System.Text;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace OutSystems.NssExtension
{

    public class CssExtension : IssExtension
    {
        /// <summary>
        /// 
        /// </summary>
        public void MssTestEmailSender(string ssEmails)
        {
            // TODO: Write implementation for action
            try
            {
                // Create a MailMessage
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("ehealth.notification@moh.gov.om");
                foreach (var email in ssEmails.Split(','))
                {
                    string trimmedEmail = email.Trim();
                    // Set the sender and receiver addresses
                    if (IsValidEmail(trimmedEmail))
                        mail.To.Add(trimmedEmail);
                    else
                        GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, $"Invalid email: {trimmedEmail}", "testEmail");
                }

                if (mail.To.Count > 0)
                {
                    // Set the subject and body
                    mail.Subject = "Test Email from Developmnet Environment";
                    mail.Body = "Hello, this is a test email with an attachment sent from C# from Developmnet Environment.";

                    // Add an attachment
                    //string attachmentPath = @"C:\path\to\your\file.txt"; // Change to your file path
                    //Attachment attachment = new Attachment(attachmentPath);
                    //mail.Attachments.Add(attachment);

                    // Configure the SMTP client
                    SmtpClient smtp = new SmtpClient("10.99.8.161", 25); // Use your SMTP server and port
                    smtp.Credentials = new NetworkCredential("ehealth.notification@moh.gov.om", "Moh@02052023");
                    smtp.EnableSsl = false; // Set to true if your SMTP server uses SSL

                    // Send the email
                    smtp.Send(mail);
                    GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, "Test Email sent successfully", "testEmail");
                }
                else
                    GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, "No Email to send", "testEmail");
            }
            catch (Exception ex)
            {
                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, ex.Message, "testEmail");
                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, ex.StackTrace, "testEmail");
                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, ex.ToString(), "testEmail");
            }
        } // MssTestEmailSender
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssEmails"></param>
        /// <param name="ssCCEmails"></param>
        /// <param name="ssSubject"></param>
        /// <param name="ssMessage"></param>
        /// <param name="ssParameters"></param>
        /// <param name="ssAttachments"></param>
        public void MssEmailSender(string ssEmails, string ssCCEmails, string ssSubject, string ssMessage, RLTemplateParameterRecordList ssParameters, RLAttachmentsRecordList ssAttachments)
        {
            // TODO: Write implementation for action
            // TODO: Write implementation for action
            try
            {
                // Create a MailMessage
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("ehealth.notification@moh.gov.om");
                foreach (var email in ssEmails.Split(','))
                {
                    string trimmedEmail = email.Trim();
                    // Set the sender and receiver addresses
                    if (IsValidEmail(trimmedEmail))
                        mail.To.Add(trimmedEmail);
                    else
                        GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, $"Invalid email: {trimmedEmail}", "Email");
                }

                foreach (var cc in ssCCEmails.Split(','))
                {
                    string trimccEmails = cc.Trim();
                    if (IsValidEmail(trimccEmails))
                        mail.CC.Add(trimccEmails);
                    else
                        GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, $"Invalid email: {trimccEmails}", "CCEmail");
                }

                if (mail.To.Count > 0)
                {
                    // Set the subject and body
                    mail.Subject = ssSubject;
                    mail.SubjectEncoding = Encoding.UTF8;
                    mail.BodyEncoding = Encoding.UTF8;
                    string finalMessage =  ReplacePlaceholders(ssMessage, ssParameters);

                    GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, $"Final email body length: {(finalMessage == null ? 0 : finalMessage.Length)}","Email");

                    AlternateView htmlView =
                     AlternateView.CreateAlternateViewFromString(
                         finalMessage,
                         Encoding.UTF8,
                         MediaTypeNames.Text.Html
                     );

                    AddLogo(htmlView);

                    mail.AlternateViews.Add(htmlView);
                    mail.IsBodyHtml = true;
                    mail.Body = finalMessage;

                    if (ssAttachments != null)
                        mail.Attachments.AddRange(AddAttachment(ssAttachments));


                    // Add an attachment
                    //string attachmentPath = @"C:\path\to\your\file.txt"; // Change to your file path
                    //Attachment attachment = new Attachment(attachmentPath);
                    //mail.Attachments.Add(attachment);

                    // Configure the SMTP client
                    SmtpClient smtp = new SmtpClient("10.99.8.161", 25); // Use your SMTP server and port
                    smtp.Credentials = new NetworkCredential("ehealth.notification@moh.gov.om", "Moh@02052023");
                    smtp.EnableSsl = false; // Set to true if your SMTP server uses SSL

                    // Send the email
                    smtp.Send(mail);
                    GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, "Email sent successfully", "Email");
                    smtp.Dispose();
                    mail.Dispose();
                }
                else
                    GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, "No Email to send", "Email");
            }
            catch (Exception ex)
            {
                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, ex.Message, "Email");
                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, ex.StackTrace, "Email");
                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, ex.ToString(), "Email");
            }

        } // MssEmailSender

        static List<Attachment> AddAttachment(RLAttachmentsRecordList ssAttachment)
        {
            List<Attachment> attachments = new List<Attachment>();

            if (ssAttachment != null && !ssAttachment.Empty)
            {
                for (int i = 0; i < ssAttachment.Length; i++)
                {
                    var attachmentRecord = ssAttachment[i].ssSTAttachments;

                    byte[] fileData = attachmentRecord.ssFileContent;
                    string fileName = attachmentRecord.ssFileName;

                    if (fileData != null && fileData.Length > 0)
                    {
                        MemoryStream stream = new MemoryStream(fileData);

                        string mimeType = MimeMapping.GetMimeMapping(fileName);

                        Attachment attachment = new Attachment(
                            stream,
                            fileName,
                            mimeType
                        );

                        attachments.Add(attachment);
                    }
                }
            }
            return attachments;
        }

        static string ReplacePlaceholders(string message, RLTemplateParameterRecordList ssParameters)
        {
            if (string.IsNullOrEmpty(message))
                return message;

            var value = Regex.Replace(message, @"\{(\d+)\}", match =>
            {
                if (int.TryParse(match.Groups[1].Value, out int index) && index >= 0 && index < ssParameters.Count)
                {
                    return WebUtility.HtmlEncode(ssParameters[index].ssSTTemplateParameter.ssText ?? string.Empty);
                }

                return match.Value;

            });

            return value;
        }

        static void AddLogo(AlternateView htmlView)
        {
            try
            {
                // Get extension runtime folder
                string basePath = AppDomain.CurrentDomain.BaseDirectory;

                // Logo path
                string logoPath = Path.Combine(basePath, "Images", "MoHMainLeftAligned.png");

                // Check whether logo exists
                if (!File.Exists(logoPath))
                {
                    GenericExtendedActions.LogMessage(
                        AppInfo.GetAppInfo().OsContext,
                        $"Logo not found: {logoPath}",
                        "Email"
                    );
                    return;
                }

                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, $"{logoPath}", "Logo image path");
                // Read logo
                byte[] ImageBytes = File.ReadAllBytes(logoPath);

                // Create memory stream
                MemoryStream imageStream = new MemoryStream(ImageBytes);

                //ContentType contentType = new ContentType("image/png")
                //{
                //    Name = "MoHMainLeftAligned.png"
                //};

                // Create inline image
                //LinkedResource logo = new LinkedResource(logoStream, contentType);

                LinkedResource logo = new LinkedResource(imageStream, "image/png");
                //{
                //    ContentId = "MoHMainLeftAligned",
                //    TransferEncoding = TransferEncoding.Base64,
                //    //ContentLink = new Uri("cid:MoHMainLeftAligned")
                //};

                logo.ContentId = "MoHMainLeftAligned";
                logo.ContentType.MediaType =
                    "image/png";
                logo.ContentType.Name =
                    "MoHMainLeftAligned.png";
                logo.TransferEncoding =
                    TransferEncoding.Base64;

                //logo.TransferEncoding = TransferEncoding.Base64;

                // Add image to HTML view
                htmlView.LinkedResources.Add(logo);

                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, $"Logo added successfully: {logoPath}", "Email");
            }
            catch (Exception ex)
            {
                GenericExtendedActions.LogMessage(AppInfo.GetAppInfo().OsContext, $"Error adding logo: {ex}", "Email");
            }
        }

        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    } // CssExtension

} // OutSystems.NssExtension

