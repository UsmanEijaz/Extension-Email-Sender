using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssExtension {

	/// <summary>
	/// RecordList type <code>RLNamesRecordList</code> that represents a record list of <code>Names</code>
	/// </summary>
	[Serializable()]
	public partial class RLNamesRecordList: GenericRecordList<RCNamesRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCNamesRecord GetElementDefaultValue() {
			return new RCNamesRecord("");
		}

		public T[] ToArray<T>(Func<RCNamesRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLNamesRecordList recordlist, Func<RCNamesRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLNamesRecordList(RCNamesRecord[] array) {
			RLNamesRecordList result = new RLNamesRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLNamesRecordList ToList<T>(T[] array, Func <T, RCNamesRecord> converter) {
			RLNamesRecordList result = new RLNamesRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLNamesRecordList FromRestList<T>(RestList<T> restList, Func <T, RCNamesRecord> converter) {
			RLNamesRecordList result = new RLNamesRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLNamesRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLNamesRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLNamesRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLNamesRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(2, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCNamesRecord> NewList() {
			return new RLNamesRecordList();
		}


	} // RLNamesRecordList

	/// <summary>
	/// RecordList type <code>RLTemplateParameterRecordList</code> that represents a record list of
	///  <code>TemplateParameter</code>
	/// </summary>
	[Serializable()]
	public partial class RLTemplateParameterRecordList: GenericRecordList<RCTemplateParameterRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTemplateParameterRecord GetElementDefaultValue() {
			return new RCTemplateParameterRecord("");
		}

		public T[] ToArray<T>(Func<RCTemplateParameterRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTemplateParameterRecordList recordlist, Func<RCTemplateParameterRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTemplateParameterRecordList(RCTemplateParameterRecord[] array) {
			RLTemplateParameterRecordList result = new RLTemplateParameterRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTemplateParameterRecordList ToList<T>(T[] array, Func <T, RCTemplateParameterRecord> converter) {
			RLTemplateParameterRecordList result = new RLTemplateParameterRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTemplateParameterRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTemplateParameterRecord> converter) {
			RLTemplateParameterRecordList result = new RLTemplateParameterRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTemplateParameterRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTemplateParameterRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTemplateParameterRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTemplateParameterRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTemplateParameterRecord> NewList() {
			return new RLTemplateParameterRecordList();
		}


	} // RLTemplateParameterRecordList

	/// <summary>
	/// RecordList type <code>RLAttachmentsRecordList</code> that represents a record list of
	///  <code>Attachments</code>
	/// </summary>
	[Serializable()]
	public partial class RLAttachmentsRecordList: GenericRecordList<RCAttachmentsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAttachmentsRecord GetElementDefaultValue() {
			return new RCAttachmentsRecord("");
		}

		public T[] ToArray<T>(Func<RCAttachmentsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAttachmentsRecordList recordlist, Func<RCAttachmentsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAttachmentsRecordList(RCAttachmentsRecord[] array) {
			RLAttachmentsRecordList result = new RLAttachmentsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAttachmentsRecordList ToList<T>(T[] array, Func <T, RCAttachmentsRecord> converter) {
			RLAttachmentsRecordList result = new RLAttachmentsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAttachmentsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAttachmentsRecord> converter) {
			RLAttachmentsRecordList result = new RLAttachmentsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAttachmentsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttachmentsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttachmentsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAttachmentsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAttachmentsRecord> NewList() {
			return new RLAttachmentsRecordList();
		}


	} // RLAttachmentsRecordList
}
