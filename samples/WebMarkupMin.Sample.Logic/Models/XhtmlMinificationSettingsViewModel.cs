﻿using System.ComponentModel.DataAnnotations;

using WebMarkupMin.Sample.Resources;

namespace WebMarkupMin.Sample.Logic.Models
{
	/// <summary>
	/// XHTML minification settings view model
	/// </summary>
	public sealed class XhtmlMinificationSettingsViewModel : CommonHtmlMinificationSettingsViewModel
	{
		[Display(Name = "DisplayName_RenderEmptyTagsWithSpace", ResourceType = typeof(XhtmlMinificationStrings))]
		public bool RenderEmptyTagsWithSpace
		{
			get;
			set;
		}
	}
}