﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Entities;
 
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Runtime.Serialization;

namespace Northwind.Domain.Orders.Entities
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.881")]
	[Serializable]
	[DataContract]
	[Table(Name = "InvoicesEntity")]
	public  partial class InvoicesEntity : Entity, IInvoicesEntity
	{
		[DataMember]
		[Column(IsPrimaryKey = true)]
		public override Guid Rsn { get; set; }

		[DataMember]
		[Column]
		public override int SortingOrder { get; set; }

		[DataMember]
		[Column]
		public override bool IsLogicallyDeleted { get; set; }

		[DataMember]
		[Column]
		public virtual string ShipName { get; set; }

		[DataMember]
		[Column]
		public virtual string ShipAddress { get; set; }

		[DataMember]
		[Column]
		public virtual string ShipCity { get; set; }

		[DataMember]
		[Column]
		public virtual string ShipRegion { get; set; }

		[DataMember]
		[Column]
		public virtual string ShipPostalCode { get; set; }

		[DataMember]
		[Column]
		public virtual string ShipCountry { get; set; }

		[DataMember]
		[Column]
		public virtual int CustomerId { get; set; }

		[DataMember]
		[Column]
		public virtual string CompanyName { get; set; }

		[DataMember]
		[Column]
		public virtual string Address { get; set; }

		[DataMember]
		[Column]
		public virtual string City { get; set; }

		[DataMember]
		[Column]
		public virtual string Region { get; set; }

		[DataMember]
		[Column]
		public virtual string PostalCode { get; set; }

		[DataMember]
		[Column]
		public virtual string Country { get; set; }

		[DataMember]
		[Column]
		public virtual string Salesperson { get; set; }

		[DataMember]
		[Column]
		public virtual int OrderId { get; set; }

		[DataMember]
		[Column]
		public virtual DateTime OrderDate { get; set; }

		[DataMember]
		[Column]
		public virtual DateTime RequiredDate { get; set; }

		[DataMember]
		[Column]
		public virtual DateTime ShippedDate { get; set; }

		[DataMember]
		[Column]
		public virtual string ShipperName { get; set; }

		[DataMember]
		[Column]
		public virtual int ProductId { get; set; }

		[DataMember]
		[Column]
		public virtual string ProductName { get; set; }

		[DataMember]
		[Column]
		public virtual double UnitPrice { get; set; }

		[DataMember]
		[Column]
		public virtual int Quantity { get; set; }

		[DataMember]
		[Column]
		public virtual double Discount { get; set; }

		[DataMember]
		[Column]
		public virtual double ExtendedPrice { get; set; }

		[DataMember]
		[Column]
		public virtual double Freight { get; set; }

	}
}
