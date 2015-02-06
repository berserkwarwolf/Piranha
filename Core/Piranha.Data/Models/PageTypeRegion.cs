﻿using System;

namespace Piranha.Models
{
	public sealed class PageTypeRegion : IModel, IModified, IModifiedBy
	{
		public Guid Id { get; set; }
		public Guid PageTypeId { get; set; }
		public string InternalId { get; set; }
		public int SortOrder { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string CLRType { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		public Guid CreatedById { get; set; }
		public Guid UpdatedById { get; set; }

		public User CreatedBy { get; set; }
		public User UpdatedBy { get; set; }
	}
}
