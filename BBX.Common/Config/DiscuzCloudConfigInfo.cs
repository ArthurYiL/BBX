using System;
using System.ComponentModel;
using NewLife.Xml;

namespace Discuz.Config
{
    [XmlConfigFile("config/dzcloud.config", 15000)]
    /// <summary>������</summary>
    [Description("������")]
    [Serializable]
    public class DiscuzCloudConfigInfo : XmlConfig2<DiscuzCloudConfigInfo>
    {
        private string m_sitekey = "";
        
        private int m_cloudenabled;
        /// <summary>����</summary>
        [Description("����")]
        public int Cloudenabled { get { return m_cloudenabled; } set { m_cloudenabled = value; } }

        private string m_cloudsiteid = "";
        /// <summary>վ���ʶ</summary>
        [Description("վ���ʶ")]
        public string Cloudsiteid { get { return m_cloudsiteid; } set { m_cloudsiteid = value; } }

        private string m_cloudsitekey = "";
        /// <summary>��վ��Key</summary>
        [Description("��վ��Key")]
        public string Cloudsitekey { get { return m_cloudsitekey; } set { m_cloudsitekey = value; } }

        /// <summary>����</summary>
        [Description("վ��Key")]
        public string Sitekey
        {
            get
            {
                if (this.m_sitekey == "")
                {
                    string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    Random random = new Random();
                    for (int i = 1; i <= 16; i++)
                    {
                        this.m_sitekey += text.Substring(random.Next(text.Length), 1);
                    }
                }
                return this.m_sitekey;
            }
            set { m_sitekey = value; }
        }

        private int m_connectenabled;
        /// <summary>��������</summary>
        [Description("��������")]
        public int Connectenabled { get { return m_connectenabled; } set { m_connectenabled = value; } }

        private string m_connectappid = "";
        /// <summary>Ӧ��ID</summary>
        [Description("Ӧ��ID")]
        public string Connectappid { get { return m_connectappid; } set { m_connectappid = value; } }

        private string m_connectappkey = "";
        /// <summary>Ӧ��Key</summary>
        [Description("Ӧ��Key")]
        public string Connectappkey { get { return m_connectappkey; } set { m_connectappkey = value; } }

        private int m_allowconnectregister = 1;
        /// <summary>����ע��</summary>
        [Description("����ע��")]
        public int Allowconnectregister { get { return m_allowconnectregister; } set { m_allowconnectregister = value; } }

        private int m_allowuseqzavater = 1;
        /// <summary>����ͷ��</summary>
        [Description("����ͷ��")]
        public int Allowuseqzavater { get { return m_allowuseqzavater; } set { m_allowuseqzavater = value; } }

        private int m_maxuserbindcount;
        /// <summary>�����û���</summary>
        [Description("�����û���")]
        public int Maxuserbindcount { get { return m_maxuserbindcount; } set { m_maxuserbindcount = value; } }

        //public static DiscuzCloudConfigInfo CreateInstance()
        //{
        //    return new DiscuzCloudConfigInfo();
        //}
    }
}