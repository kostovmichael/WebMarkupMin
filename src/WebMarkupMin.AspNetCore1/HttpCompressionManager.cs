﻿using Microsoft.Extensions.Options;

using WebMarkupMin.AspNet.Common;

#if ASPNETCORE1
namespace WebMarkupMin.AspNetCore1
#elif ASPNETCORE2
namespace WebMarkupMin.AspNetCore2
#elif ASPNETCORE3
namespace WebMarkupMin.AspNetCore3
#else
#error No implementation for this target
#endif
{
	/// <summary>
	/// HTTP compression manager
	/// </summary>
	public sealed class HttpCompressionManager : HttpCompressionManagerBase
	{
		/// <summary>
		/// Constructs a instance of HTTP compression manager
		/// </summary>
		/// <param name="options">HTTP compression options</param>
		public HttpCompressionManager(IOptions<HttpCompressionOptions> options)
		{
			HttpCompressionOptions compressionOptions = options.Value;

			CompressorFactories = compressionOptions.CompressorFactories;
			SupportedHttpMethods = compressionOptions.SupportedHttpMethods;
			SupportedMediaTypePredicate = compressionOptions.SupportedMediaTypePredicate;
			IncludedPages = compressionOptions.IncludedPages;
			ExcludedPages = compressionOptions.ExcludedPages;
		}
	}
}