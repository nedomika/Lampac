﻿namespace Shared.Model.Base
{
    public interface Istreamproxy
    {
        public bool useproxystream { get; set; }

        public bool streamproxy { get; set; }

        public bool qualitys_proxy { get; set; }

        public ProxySettings? proxy { get; set; }
    }
}
