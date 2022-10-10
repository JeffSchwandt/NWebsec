// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using System.Configuration;

namespace NWebsec.Modules.Configuration.Csp
{
    public class CspDirectiveUnsafeInlineConfigurationElement : CspDirectiveBaseConfigurationElement<CspHashSourceConfigurationElement>
    {
        [ConfigurationProperty("unsafeInline", IsRequired = false, DefaultValue = false)]
        public override bool UnsafeInlineSrc
        {
            get => (bool)this["unsafeInline"];
            set => this["unsafeInline"] = value;
        }

        [ConfigurationProperty("nonceEnabled", IsRequired = false, DefaultValue = false)]
        public bool NonceEnabled
        {
            get => (bool)this["nonceEnabled"];
            set => this["nonceEnabled"] = value;
        }
    }
}
