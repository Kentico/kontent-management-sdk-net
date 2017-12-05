﻿using System;

using KenticoCloud.ContentManagement.Models.Identifiers;

namespace KenticoCloud.ContentManagement.Models.Items
{
    public sealed class LanguageIdentifier : IdentifierWithCodename<LanguageIdentifier>
    {
        [Obsolete("For internal purposes. Use static method LanguageIdentifier.ByXYZ instead.")]
        public LanguageIdentifier() { }


        public static readonly LanguageIdentifier DEFAULT_LANGUAGE = LanguageIdentifier.ById(Guid.Empty);
    }
}
