﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixData.Version3
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OnixTextContent
    {
        #region CONSTANTS

        public const int CONST_OTEXT_TYPE_MAIN_DESC   = 1;
        public const int CONST_OTEXT_TYPE_ANNOTATION  = 2;
        public const int CONST_OTEXT_TYPE_REV_QUOTE   = 8;
        public const int CONST_OTEXT_TYPE_SERIES_DESC = 43;
        
        #endregion

        public OnixTextContent()
        {
            TextType = ContentAudience = -1;

            Text = "";
        }

        private int    textTypeField;
        private int    contentAudienceField;
        private string textField;

        /// <remarks/>
        public int TextType
        {
            get
            {
                return this.textTypeField;
            }
            set
            {
                this.textTypeField = value;
            }
        }

        /// <remarks/>
        public int ContentAudience
        {
            get
            {
                return this.contentAudienceField;
            }
            set
            {
                this.contentAudienceField = value;
            }
        }

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
}
