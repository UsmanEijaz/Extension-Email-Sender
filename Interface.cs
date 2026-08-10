using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssExtension {

	public interface IssExtension {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEmails"></param>
		void MssTestEmailSender(string ssEmails);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEmails"></param>
		/// <param name="ssCCEmails"></param>
		/// <param name="ssSubject"></param>
		/// <param name="ssMessage"></param>
		/// <param name="ssParameters"></param>
		/// <param name="ssAttachments"></param>
		void MssEmailSender(string ssEmails, string ssCCEmails, string ssSubject, string ssMessage, RLTemplateParameterRecordList ssParameters, RLAttachmentsRecordList ssAttachments);

	} // IssExtension

} // OutSystems.NssExtension
