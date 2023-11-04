﻿namespace Shared.Model.Base
{
    public class BaseSettings : Iproxy, Istreamproxy, Icors
    {
        public bool enable { get; set; }

        public string? displayname { get; set; }

        public string? host { get; set; }

        public string? apihost { get; set; }


        #region proxy
        public bool useproxy { get; set; }

        public string? globalnameproxy { get; set; }

        public ProxySettings? proxy { get; set; }

        public bool useproxystream { get; set; }

        public bool streamproxy { get; set; }

        public bool qualitys_proxy { get; set; }
        #endregion

        #region cors
        public bool corseu { get; set; }

        public string? webcorshost { get; set; }

        public string corsHost()
        {
            string? crhost = !string.IsNullOrWhiteSpace(webcorshost) ? webcorshost : corseu ? AppInit.corseuhost : null;
            if (string.IsNullOrWhiteSpace(crhost))
                return host;

            return $"{crhost}/{host}";
        }

        public string corsHost(string uri)
        {
            string? crhost = !string.IsNullOrWhiteSpace(webcorshost) ? webcorshost : corseu ? AppInit.corseuhost : null;
            if (string.IsNullOrWhiteSpace(crhost) || string.IsNullOrWhiteSpace(uri) || uri.Contains(crhost))
                return uri;

            return $"{crhost}/{uri}";
        }
        #endregion
    }
}
