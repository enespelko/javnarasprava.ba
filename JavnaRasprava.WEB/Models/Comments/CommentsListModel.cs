﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavnaRasprava.WEB.Models
{
	public class CommentsListModel
	{
		#region == Fields ==

		#endregion

		#region == Properties ==

		public int LawID { get; set; }

		public ICollection<CommentModel> Comments { get; set; }

		#endregion

		#region == Constructors ==

		#endregion

		#region == Methods ==

		#endregion
	}
}