using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwainDotNet;

namespace Kibernetes.Services.ScannerLibrary
{
    public class ScannerSetting
    {
        public ScannerSetting() { }
        public PageSettings Page { get; set; }
        public AreaSettings Area { get; set; }
        public bool? UseDuplex { get; set; }
        public ResolutionSettings Resolution { get; set; }
        public bool ShouldTransferAllPages { get; set; }
        public short TransferCount { get; set; }
        public bool? UseAutoScanCache { get; set; }
        public RotationSettings Rotation { get; set; }
        public bool? UseAutoFeeder { get; set; }
        public bool? UseDocumentFeeder { get; set; }
        public bool? ShowProgressIndicatorUI { get; set; }
        public bool ShowTwainUI { get; set; }
        public bool AbortWhenNoPaperDetectable { get; set; }
    }
}
