using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssExtension {

	/// <summary>
	/// Structure <code>STTemplateParameterStructure</code> that represents the Service Studio structure
	///  <code>TemplateParameter</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STTemplateParameterStructure: ISerializable, ITypedRecord<STTemplateParameterStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("0QJsjB5RS0mqifGVn6+CJw*_PV6MfKh_k2fuYjFxJABdw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Text")]
		public string ssText;


		public BitArray OptimizedAttributes;

		public STTemplateParameterStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssText = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssText = r.ReadText(index++, "TemplateParameter.Text", "");
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(STTemplateParameterStructure r) {
			this = r;
		}


		public static bool operator == (STTemplateParameterStructure a, STTemplateParameterStructure b) {
			if (a.ssText != b.ssText) return false;
			return true;
		}

		public static bool operator != (STTemplateParameterStructure a, STTemplateParameterStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STTemplateParameterStructure)) return false;
			return (this == (STTemplateParameterStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssText.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public STTemplateParameterStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssText = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssText", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssText' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssText = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STTemplateParameterStructure Duplicate() {
			STTemplateParameterStructure t;
			t.ssText = this.ssText;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Text")) VarValue.AppendAttribute(recordElem, "Text", ssText, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Text");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "text") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssText; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdText) {
				return ssText;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssText = (string) other.AttributeGet(IdText);
		}
		public bool IsDefault() {
			STTemplateParameterStructure defaultStruct = new STTemplateParameterStructure(null);
			if (this.ssText != defaultStruct.ssText) return false;
			return true;
		}
	} // STTemplateParameterStructure

	/// <summary>
	/// Structure <code>STAttachmentsStructure</code> that represents the Service Studio structure
	///  <code>Attachments</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAttachmentsStructure: ISerializable, ITypedRecord<STAttachmentsStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("0QJsjB5RS0mqifGVn6+CJw*CIdFie1vgE+Yk1NkXhO3ZQ");
		internal static readonly GlobalObjectKey IdFileContent = GlobalObjectKey.Parse("0QJsjB5RS0mqifGVn6+CJw*PhUfpxE6kU2yoe2d+8Jmgg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("FileName")]
		public string ssFileName;

		[System.Xml.Serialization.XmlElement("FileContent")]
		public byte[] ssFileContent;


		public BitArray OptimizedAttributes;

		public STAttachmentsStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssFileName = "";
			ssFileContent = new byte[] {};
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssFileName = r.ReadText(index++, "Attachments.FileName", "");
			ssFileContent = r.ReadBinaryData(index++, "Attachments.FileContent", new byte[] {});
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(STAttachmentsStructure r) {
			this = r;
		}


		public static bool operator == (STAttachmentsStructure a, STAttachmentsStructure b) {
			if (a.ssFileName != b.ssFileName) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(a.ssFileContent, b.ssFileContent)) return false;
			return true;
		}

		public static bool operator != (STAttachmentsStructure a, STAttachmentsStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAttachmentsStructure)) return false;
			return (this == (STAttachmentsStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssFileName.GetHashCode()
				^ ssFileContent.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public STAttachmentsStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssFileName = "";
			ssFileContent = new byte[] {};
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssFileName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssFileName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssFileName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssFileContent", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssFileContent' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssFileContent = (byte[]) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAttachmentsStructure Duplicate() {
			STAttachmentsStructure t;
			t.ssFileName = this.ssFileName;
			if (this.ssFileContent != null) {
				t.ssFileContent = (byte[]) this.ssFileContent.Clone();
			} else {
				t.ssFileContent = null;
			}
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".FileName")) VarValue.AppendAttribute(recordElem, "FileName", ssFileName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "FileName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".FileContent")) VarValue.AppendAttribute(recordElem, "FileContent", ssFileContent, detailLevel, TypeKind.BinaryData); else VarValue.AppendOptimizedAttribute(recordElem, "FileContent");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "filename") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
			} else if (head == "filecontent") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FileContent")) variable.Value = ssFileContent; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdFileName) {
				return ssFileName;
			} else if (key == IdFileContent) {
				return ssFileContent;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssFileName = (string) other.AttributeGet(IdFileName);
			ssFileContent = (byte[]) other.AttributeGet(IdFileContent);
		}
		public bool IsDefault() {
			STAttachmentsStructure defaultStruct = new STAttachmentsStructure(null);
			if (this.ssFileName != defaultStruct.ssFileName) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(this.ssFileContent, defaultStruct.ssFileContent)) return false;
			return true;
		}
	} // STAttachmentsStructure

} // OutSystems.NssExtension
