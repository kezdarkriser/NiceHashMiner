﻿using NiceHashMiner.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NiceHashMiner.Miners.Parsing {
    public class MinerOption {
        public MinerOption(MinerOptionType iType, string iShortName, string iLongName, string iDefault, MinerOptionFlagType iFlagType, string iSeparator) {
            this.Type = iType;
            this.ShortName = iShortName;
            this.LongName = iLongName;
            this.Default = iDefault;
            this.FlagType = iFlagType;
            this.Separator = iSeparator;
        }
        public readonly MinerOptionType Type;
        public readonly string ShortName;
        public readonly string LongName;
        public readonly string Default;
        public readonly MinerOptionFlagType FlagType;
        public readonly string Separator;
    }
}
