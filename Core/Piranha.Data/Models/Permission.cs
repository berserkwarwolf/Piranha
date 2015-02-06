﻿/*
 * Copyright (c) 2011-2015 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha
 * 
 */

using System;

namespace Piranha.Models
{
	public sealed class Permission : IModel, IModified
	{
		public Guid Id { get; set; }
		public Guid GroupId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsSystem { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		public Guid? CreatedById { get; set; }
		public Guid? UpdatedById { get; set; }

		public User CreatedBy { get; set; }
		public User UpdatedBy { get; set; }
	}
}
