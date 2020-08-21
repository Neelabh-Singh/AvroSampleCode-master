// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace com.shanidgafur.error
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ErrorDetails : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ErrorDetails"",""namespace"":""com.shanidgafur.error"",""fields"":[{""name"":""category"",""doc"":""Category of the error. Example: DatabaseConnectionError"",""type"":""string""},{""name"":""severity"",""doc"":""The severity of the error. Example: CRITICAL, FATAL, WARNING"",""type"":""string""},{""name"":""timestamp"",""doc"":""Timestamp (milliseconds since epoch) when the error was generated"",""type"":""long""}]}");
		/// <summary>
		/// Category of the error. Example: DatabaseConnectionError
		/// </summary>
		private string _category;
		/// <summary>
		/// The severity of the error. Example: CRITICAL, FATAL, WARNING
		/// </summary>
		private string _severity;
		/// <summary>
		/// Timestamp (milliseconds since epoch) when the error was generated
		/// </summary>
		private long _timestamp;
		public virtual Schema Schema
		{
			get
			{
				return ErrorDetails._SCHEMA;
			}
		}
		/// <summary>
		/// Category of the error. Example: DatabaseConnectionError
		/// </summary>
		public string Category
		{
			get
			{
				return this._category;
			}
			set
			{
				this._category = value;
			}
		}
		/// <summary>
		/// The severity of the error. Example: CRITICAL, FATAL, WARNING
		/// </summary>
		public string Severity
		{
			get
			{
				return this._severity;
			}
			set
			{
				this._severity = value;
			}
		}
		/// <summary>
		/// Timestamp (milliseconds since epoch) when the error was generated
		/// </summary>
		public long Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._category;
			case 1: return this._severity;
			case 2: return this._timestamp;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._category = (System.String)fieldValue; break;
			case 1: this._severity = (System.String)fieldValue; break;
			case 2: this._timestamp = (System.Int64)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}