using Cosmos.System;
using Cosmos.System.FileSystem;
using Cosmos.System.Graphics;
using sexOSKernel.Commands;
using System;
using System.Drawing;
using Sys = Cosmos.System;
using Console = System.Console;
using System.Collections.Generic;
using System.Net.Http.Headers;
using IL2CPU.API.Attribs;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Linq;
using System.Text.RegularExpressions;

namespace sexOSKernel.Graphics
{
    public class badApple
    {
        public bool ShouldExitApple { get; private set; } = false;

        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0001.bmp")]
        public static byte[] test_image1;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0002.bmp")]
        public static byte[] test_image2;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0003.bmp")]
        public static byte[] test_image3;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0004.bmp")]
        public static byte[] test_image4;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0005.bmp")]
        public static byte[] test_image5;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0006.bmp")]
        public static byte[] test_image6;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0007.bmp")]
        public static byte[] test_image7;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0008.bmp")]
        public static byte[] test_image8;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0009.bmp")]
        public static byte[] test_image9;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0010.bmp")]
        public static byte[] test_image10;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0011.bmp")]
        public static byte[] test_image11;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0012.bmp")]
        public static byte[] test_image12;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0013.bmp")]
        public static byte[] test_image13;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0014.bmp")]
        public static byte[] test_image14;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0015.bmp")]
        public static byte[] test_image15;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0016.bmp")]
        public static byte[] test_image16;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0017.bmp")]
        public static byte[] test_image17;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0018.bmp")]
        public static byte[] test_image18;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0019.bmp")]
        public static byte[] test_image19;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0020.bmp")]
        public static byte[] test_image20;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0021.bmp")]
        public static byte[] test_image21;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0022.bmp")]
        public static byte[] test_image22;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0023.bmp")]
        public static byte[] test_image23;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0024.bmp")]
        public static byte[] test_image24;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0025.bmp")]
        public static byte[] test_image25;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0026.bmp")]
        public static byte[] test_image26;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0027.bmp")]
        public static byte[] test_image27;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0028.bmp")]
        public static byte[] test_image28;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0029.bmp")]
        public static byte[] test_image29;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0030.bmp")]
        public static byte[] test_image30;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0031.bmp")]
        public static byte[] test_image31;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0032.bmp")]
        public static byte[] test_image32;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0033.bmp")]
        public static byte[] test_image33;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0034.bmp")]
        public static byte[] test_image34;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0035.bmp")]
        public static byte[] test_image35;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0036.bmp")]
        public static byte[] test_image36;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0037.bmp")]
        public static byte[] test_image37;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0038.bmp")]
        public static byte[] test_image38;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0039.bmp")]
        public static byte[] test_image39;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0040.bmp")]
        public static byte[] test_image40;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0041.bmp")]
        public static byte[] test_image41;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0042.bmp")]
        public static byte[] test_image42;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0043.bmp")]
        public static byte[] test_image43;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0044.bmp")]
        public static byte[] test_image44;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0045.bmp")]
        public static byte[] test_image45;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0046.bmp")]
        public static byte[] test_image46;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0047.bmp")]
        public static byte[] test_image47;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0048.bmp")]
        public static byte[] test_image48;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0049.bmp")]
        public static byte[] test_image49;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0050.bmp")]
        public static byte[] test_image50;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0051.bmp")]
        public static byte[] test_image51;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0052.bmp")]
        public static byte[] test_image52;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0053.bmp")]
        public static byte[] test_image53;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0054.bmp")]
        public static byte[] test_image54;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0055.bmp")]
        public static byte[] test_image55;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0056.bmp")]
        public static byte[] test_image56;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0057.bmp")]
        public static byte[] test_image57;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0058.bmp")]
        public static byte[] test_image58;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0059.bmp")]
        public static byte[] test_image59;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0060.bmp")]
        public static byte[] test_image60;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0061.bmp")]
        public static byte[] test_image61;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0062.bmp")]
        public static byte[] test_image62;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0063.bmp")]
        public static byte[] test_image63;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0064.bmp")]
        public static byte[] test_image64;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0065.bmp")]
        public static byte[] test_image65;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0066.bmp")]
        public static byte[] test_image66;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0067.bmp")]
        public static byte[] test_image67;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0068.bmp")]
        public static byte[] test_image68;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0069.bmp")]
        public static byte[] test_image69;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0070.bmp")]
        public static byte[] test_image70;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0071.bmp")]
        public static byte[] test_image71;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0072.bmp")]
        public static byte[] test_image72;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0073.bmp")]
        public static byte[] test_image73;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0074.bmp")]
        public static byte[] test_image74;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0075.bmp")]
        public static byte[] test_image75;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0076.bmp")]
        public static byte[] test_image76;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0077.bmp")]
        public static byte[] test_image77;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0078.bmp")]
        public static byte[] test_image78;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0079.bmp")]
        public static byte[] test_image79;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0080.bmp")]
        public static byte[] test_image80;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0081.bmp")]
        public static byte[] test_image81;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0082.bmp")]
        public static byte[] test_image82;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0083.bmp")]
        public static byte[] test_image83;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0084.bmp")]
        public static byte[] test_image84;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0085.bmp")]
        public static byte[] test_image85;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0086.bmp")]
        public static byte[] test_image86;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0087.bmp")]
        public static byte[] test_image87;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0088.bmp")]
        public static byte[] test_image88;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0089.bmp")]
        public static byte[] test_image89;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0090.bmp")]
        public static byte[] test_image90;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0091.bmp")]
        public static byte[] test_image91;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0092.bmp")]
        public static byte[] test_image92;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0093.bmp")]
        public static byte[] test_image93;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0094.bmp")]
        public static byte[] test_image94;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0095.bmp")]
        public static byte[] test_image95;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0096.bmp")]
        public static byte[] test_image96;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0097.bmp")]
        public static byte[] test_image97;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0098.bmp")]
        public static byte[] test_image98;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0099.bmp")]
        public static byte[] test_image99;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0100.bmp")]
        public static byte[] test_image100;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0101.bmp")]
        public static byte[] test_image101;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0102.bmp")]
        public static byte[] test_image102;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0103.bmp")]
        public static byte[] test_image103;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0104.bmp")]
        public static byte[] test_image104;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0105.bmp")]
        public static byte[] test_image105;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0106.bmp")]
        public static byte[] test_image106;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0107.bmp")]
        public static byte[] test_image107;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0108.bmp")]
        public static byte[] test_image108;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0109.bmp")]
        public static byte[] test_image109;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0110.bmp")]
        public static byte[] test_image110;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0111.bmp")]
        public static byte[] test_image111;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0112.bmp")]
        public static byte[] test_image112;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0113.bmp")]
        public static byte[] test_image113;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0114.bmp")]
        public static byte[] test_image114;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0115.bmp")]
        public static byte[] test_image115;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0116.bmp")]
        public static byte[] test_image116;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0117.bmp")]
        public static byte[] test_image117;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0118.bmp")]
        public static byte[] test_image118;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0119.bmp")]
        public static byte[] test_image119;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0120.bmp")]
        public static byte[] test_image120;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0121.bmp")]
        public static byte[] test_image121;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0122.bmp")]
        public static byte[] test_image122;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0123.bmp")]
        public static byte[] test_image123;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0124.bmp")]
        public static byte[] test_image124;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0125.bmp")]
        public static byte[] test_image125;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0126.bmp")]
        public static byte[] test_image126;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0127.bmp")]
        public static byte[] test_image127;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0128.bmp")]
        public static byte[] test_image128;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0129.bmp")]
        public static byte[] test_image129;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0130.bmp")]
        public static byte[] test_image130;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0131.bmp")]
        public static byte[] test_image131;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0132.bmp")]
        public static byte[] test_image132;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0133.bmp")]
        public static byte[] test_image133;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0134.bmp")]
        public static byte[] test_image134;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0135.bmp")]
        public static byte[] test_image135;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0136.bmp")]
        public static byte[] test_image136;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0137.bmp")]
        public static byte[] test_image137;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0138.bmp")]
        public static byte[] test_image138;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0139.bmp")]
        public static byte[] test_image139;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0140.bmp")]
        public static byte[] test_image140;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0141.bmp")]
        public static byte[] test_image141;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0142.bmp")]
        public static byte[] test_image142;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0143.bmp")]
        public static byte[] test_image143;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0144.bmp")]
        public static byte[] test_image144;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0145.bmp")]
        public static byte[] test_image145;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0146.bmp")]
        public static byte[] test_image146;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0147.bmp")]
        public static byte[] test_image147;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0148.bmp")]
        public static byte[] test_image148;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0149.bmp")]
        public static byte[] test_image149;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0150.bmp")]
        public static byte[] test_image150;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0151.bmp")]
        public static byte[] test_image151;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0152.bmp")]
        public static byte[] test_image152;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0153.bmp")]
        public static byte[] test_image153;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0154.bmp")]
        public static byte[] test_image154;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0155.bmp")]
        public static byte[] test_image155;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0156.bmp")]
        public static byte[] test_image156;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0157.bmp")]
        public static byte[] test_image157;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0158.bmp")]
        public static byte[] test_image158;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0159.bmp")]
        public static byte[] test_image159;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0160.bmp")]
        public static byte[] test_image160;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0161.bmp")]
        public static byte[] test_image161;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0162.bmp")]
        public static byte[] test_image162;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0163.bmp")]
        public static byte[] test_image163;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0164.bmp")]
        public static byte[] test_image164;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0165.bmp")]
        public static byte[] test_image165;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0166.bmp")]
        public static byte[] test_image166;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0167.bmp")]
        public static byte[] test_image167;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0168.bmp")]
        public static byte[] test_image168;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0169.bmp")]
        public static byte[] test_image169;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0170.bmp")]
        public static byte[] test_image170;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0171.bmp")]
        public static byte[] test_image171;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0172.bmp")]
        public static byte[] test_image172;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0173.bmp")]
        public static byte[] test_image173;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0174.bmp")]
        public static byte[] test_image174;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0175.bmp")]
        public static byte[] test_image175;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0176.bmp")]
        public static byte[] test_image176;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0177.bmp")]
        public static byte[] test_image177;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0178.bmp")]
        public static byte[] test_image178;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0179.bmp")]
        public static byte[] test_image179;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0180.bmp")]
        public static byte[] test_image180;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0181.bmp")]
        public static byte[] test_image181;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0182.bmp")]
        public static byte[] test_image182;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0183.bmp")]
        public static byte[] test_image183;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0184.bmp")]
        public static byte[] test_image184;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0185.bmp")]
        public static byte[] test_image185;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0186.bmp")]
        public static byte[] test_image186;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0187.bmp")]
        public static byte[] test_image187;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0188.bmp")]
        public static byte[] test_image188;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0189.bmp")]
        public static byte[] test_image189;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0190.bmp")]
        public static byte[] test_image190;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0191.bmp")]
        public static byte[] test_image191;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0192.bmp")]
        public static byte[] test_image192;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0193.bmp")]
        public static byte[] test_image193;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0194.bmp")]
        public static byte[] test_image194;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0195.bmp")]
        public static byte[] test_image195;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0196.bmp")]
        public static byte[] test_image196;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0197.bmp")]
        public static byte[] test_image197;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0198.bmp")]
        public static byte[] test_image198;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0199.bmp")]
        public static byte[] test_image199;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0200.bmp")]
        public static byte[] test_image200;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0201.bmp")]
        public static byte[] test_image201;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0202.bmp")]
        public static byte[] test_image202;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0203.bmp")]
        public static byte[] test_image203;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0204.bmp")]
        public static byte[] test_image204;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0205.bmp")]
        public static byte[] test_image205;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0206.bmp")]
        public static byte[] test_image206;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0207.bmp")]
        public static byte[] test_image207;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0208.bmp")]
        public static byte[] test_image208;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0209.bmp")]
        public static byte[] test_image209;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0210.bmp")]
        public static byte[] test_image210;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0211.bmp")]
        public static byte[] test_image211;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0212.bmp")]
        public static byte[] test_image212;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0213.bmp")]
        public static byte[] test_image213;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0214.bmp")]
        public static byte[] test_image214;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0215.bmp")]
        public static byte[] test_image215;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0216.bmp")]
        public static byte[] test_image216;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0217.bmp")]
        public static byte[] test_image217;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0218.bmp")]
        public static byte[] test_image218;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0219.bmp")]
        public static byte[] test_image219;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0220.bmp")]
        public static byte[] test_image220;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0221.bmp")]
        public static byte[] test_image221;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0222.bmp")]
        public static byte[] test_image222;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0223.bmp")]
        public static byte[] test_image223;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0224.bmp")]
        public static byte[] test_image224;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0225.bmp")]
        public static byte[] test_image225;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0226.bmp")]
        public static byte[] test_image226;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0227.bmp")]
        public static byte[] test_image227;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0228.bmp")]
        public static byte[] test_image228;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0229.bmp")]
        public static byte[] test_image229;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0230.bmp")]
        public static byte[] test_image230;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0231.bmp")]
        public static byte[] test_image231;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0232.bmp")]
        public static byte[] test_image232;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0233.bmp")]
        public static byte[] test_image233;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0234.bmp")]
        public static byte[] test_image234;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0235.bmp")]
        public static byte[] test_image235;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0236.bmp")]
        public static byte[] test_image236;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0237.bmp")]
        public static byte[] test_image237;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0238.bmp")]
        public static byte[] test_image238;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0239.bmp")]
        public static byte[] test_image239;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0240.bmp")]
        public static byte[] test_image240;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0241.bmp")]
        public static byte[] test_image241;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0242.bmp")]
        public static byte[] test_image242;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0243.bmp")]
        public static byte[] test_image243;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0244.bmp")]
        public static byte[] test_image244;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0245.bmp")]
        public static byte[] test_image245;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0246.bmp")]
        public static byte[] test_image246;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0247.bmp")]
        public static byte[] test_image247;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0248.bmp")]
        public static byte[] test_image248;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0249.bmp")]
        public static byte[] test_image249;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0250.bmp")]
        public static byte[] test_image250;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0251.bmp")]
        public static byte[] test_image251;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0252.bmp")]
        public static byte[] test_image252;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0253.bmp")]
        public static byte[] test_image253;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0254.bmp")]
        public static byte[] test_image254;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0255.bmp")]
        public static byte[] test_image255;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0256.bmp")]
        public static byte[] test_image256;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0257.bmp")]
        public static byte[] test_image257;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0258.bmp")]
        public static byte[] test_image258;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0259.bmp")]
        public static byte[] test_image259;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0260.bmp")]
        public static byte[] test_image260;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0261.bmp")]
        public static byte[] test_image261;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0262.bmp")]
        public static byte[] test_image262;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0263.bmp")]
        public static byte[] test_image263;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0264.bmp")]
        public static byte[] test_image264;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0265.bmp")]
        public static byte[] test_image265;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0266.bmp")]
        public static byte[] test_image266;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0267.bmp")]
        public static byte[] test_image267;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0268.bmp")]
        public static byte[] test_image268;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0269.bmp")]
        public static byte[] test_image269;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0270.bmp")]
        public static byte[] test_image270;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0271.bmp")]
        public static byte[] test_image271;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0272.bmp")]
        public static byte[] test_image272;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0273.bmp")]
        public static byte[] test_image273;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0274.bmp")]
        public static byte[] test_image274;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0275.bmp")]
        public static byte[] test_image275;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0276.bmp")]
        public static byte[] test_image276;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0277.bmp")]
        public static byte[] test_image277;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0278.bmp")]
        public static byte[] test_image278;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0279.bmp")]
        public static byte[] test_image279;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0280.bmp")]
        public static byte[] test_image280;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0281.bmp")]
        public static byte[] test_image281;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0282.bmp")]
        public static byte[] test_image282;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0283.bmp")]
        public static byte[] test_image283;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0284.bmp")]
        public static byte[] test_image284;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0285.bmp")]
        public static byte[] test_image285;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0286.bmp")]
        public static byte[] test_image286;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0287.bmp")]
        public static byte[] test_image287;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0288.bmp")]
        public static byte[] test_image288;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0289.bmp")]
        public static byte[] test_image289;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0290.bmp")]
        public static byte[] test_image290;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0291.bmp")]
        public static byte[] test_image291;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0292.bmp")]
        public static byte[] test_image292;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0293.bmp")]
        public static byte[] test_image293;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0294.bmp")]
        public static byte[] test_image294;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0295.bmp")]
        public static byte[] test_image295;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0296.bmp")]
        public static byte[] test_image296;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0297.bmp")]
        public static byte[] test_image297;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0298.bmp")]
        public static byte[] test_image298;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0299.bmp")]
        public static byte[] test_image299;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0300.bmp")]
        public static byte[] test_image300;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0301.bmp")]
        public static byte[] test_image301;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0302.bmp")]
        public static byte[] test_image302;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0303.bmp")]
        public static byte[] test_image303;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0304.bmp")]
        public static byte[] test_image304;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0305.bmp")]
        public static byte[] test_image305;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0306.bmp")]
        public static byte[] test_image306;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0307.bmp")]
        public static byte[] test_image307;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0308.bmp")]
        public static byte[] test_image308;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0309.bmp")]
        public static byte[] test_image309;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0310.bmp")]
        public static byte[] test_image310;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0311.bmp")]
        public static byte[] test_image311;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0312.bmp")]
        public static byte[] test_image312;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0313.bmp")]
        public static byte[] test_image313;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0314.bmp")]
        public static byte[] test_image314;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0315.bmp")]
        public static byte[] test_image315;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0316.bmp")]
        public static byte[] test_image316;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0317.bmp")]
        public static byte[] test_image317;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0318.bmp")]
        public static byte[] test_image318;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0319.bmp")]
        public static byte[] test_image319;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0320.bmp")]
        public static byte[] test_image320;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0321.bmp")]
        public static byte[] test_image321;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0322.bmp")]
        public static byte[] test_image322;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0323.bmp")]
        public static byte[] test_image323;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0324.bmp")]
        public static byte[] test_image324;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0325.bmp")]
        public static byte[] test_image325;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0326.bmp")]
        public static byte[] test_image326;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0327.bmp")]
        public static byte[] test_image327;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0328.bmp")]
        public static byte[] test_image328;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0329.bmp")]
        public static byte[] test_image329;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0330.bmp")]
        public static byte[] test_image330;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0331.bmp")]
        public static byte[] test_image331;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0332.bmp")]
        public static byte[] test_image332;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0333.bmp")]
        public static byte[] test_image333;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0334.bmp")]
        public static byte[] test_image334;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0335.bmp")]
        public static byte[] test_image335;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0336.bmp")]
        public static byte[] test_image336;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0337.bmp")]
        public static byte[] test_image337;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0338.bmp")]
        public static byte[] test_image338;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0339.bmp")]
        public static byte[] test_image339;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0340.bmp")]
        public static byte[] test_image340;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0341.bmp")]
        public static byte[] test_image341;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0342.bmp")]
        public static byte[] test_image342;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0343.bmp")]
        public static byte[] test_image343;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0344.bmp")]
        public static byte[] test_image344;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0345.bmp")]
        public static byte[] test_image345;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0346.bmp")]
        public static byte[] test_image346;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0347.bmp")]
        public static byte[] test_image347;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0348.bmp")]
        public static byte[] test_image348;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0349.bmp")]
        public static byte[] test_image349;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0350.bmp")]
        public static byte[] test_image350;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0351.bmp")]
        public static byte[] test_image351;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0352.bmp")]
        public static byte[] test_image352;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0353.bmp")]
        public static byte[] test_image353;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0354.bmp")]
        public static byte[] test_image354;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0355.bmp")]
        public static byte[] test_image355;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0356.bmp")]
        public static byte[] test_image356;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0357.bmp")]
        public static byte[] test_image357;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0358.bmp")]
        public static byte[] test_image358;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0359.bmp")]
        public static byte[] test_image359;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0360.bmp")]
        public static byte[] test_image360;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0361.bmp")]
        public static byte[] test_image361;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0362.bmp")]
        public static byte[] test_image362;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0363.bmp")]
        public static byte[] test_image363;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0364.bmp")]
        public static byte[] test_image364;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0365.bmp")]
        public static byte[] test_image365;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0366.bmp")]
        public static byte[] test_image366;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0367.bmp")]
        public static byte[] test_image367;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0368.bmp")]
        public static byte[] test_image368;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0369.bmp")]
        public static byte[] test_image369;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0370.bmp")]
        public static byte[] test_image370;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0371.bmp")]
        public static byte[] test_image371;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0372.bmp")]
        public static byte[] test_image372;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0373.bmp")]
        public static byte[] test_image373;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0374.bmp")]
        public static byte[] test_image374;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0375.bmp")]
        public static byte[] test_image375;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0376.bmp")]
        public static byte[] test_image376;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0377.bmp")]
        public static byte[] test_image377;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0378.bmp")]
        public static byte[] test_image378;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0379.bmp")]
        public static byte[] test_image379;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0380.bmp")]
        public static byte[] test_image380;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0381.bmp")]
        public static byte[] test_image381;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0382.bmp")]
        public static byte[] test_image382;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0383.bmp")]
        public static byte[] test_image383;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0384.bmp")]
        public static byte[] test_image384;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0385.bmp")]
        public static byte[] test_image385;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0386.bmp")]
        public static byte[] test_image386;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0387.bmp")]
        public static byte[] test_image387;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0388.bmp")]
        public static byte[] test_image388;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0389.bmp")]
        public static byte[] test_image389;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0390.bmp")]
        public static byte[] test_image390;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0391.bmp")]
        public static byte[] test_image391;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0392.bmp")]
        public static byte[] test_image392;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0393.bmp")]
        public static byte[] test_image393;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0394.bmp")]
        public static byte[] test_image394;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0395.bmp")]
        public static byte[] test_image395;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0396.bmp")]
        public static byte[] test_image396;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0397.bmp")]
        public static byte[] test_image397;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0398.bmp")]
        public static byte[] test_image398;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0399.bmp")]
        public static byte[] test_image399;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0400.bmp")]
        public static byte[] test_image400;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0401.bmp")]
        public static byte[] test_image401;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0402.bmp")]
        public static byte[] test_image402;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0403.bmp")]
        public static byte[] test_image403;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0404.bmp")]
        public static byte[] test_image404;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0405.bmp")]
        public static byte[] test_image405;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0406.bmp")]
        public static byte[] test_image406;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0407.bmp")]
        public static byte[] test_image407;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0408.bmp")]
        public static byte[] test_image408;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0409.bmp")]
        public static byte[] test_image409;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0410.bmp")]
        public static byte[] test_image410;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0411.bmp")]
        public static byte[] test_image411;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0412.bmp")]
        public static byte[] test_image412;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0413.bmp")]
        public static byte[] test_image413;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0414.bmp")]
        public static byte[] test_image414;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0415.bmp")]
        public static byte[] test_image415;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0416.bmp")]
        public static byte[] test_image416;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0417.bmp")]
        public static byte[] test_image417;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0418.bmp")]
        public static byte[] test_image418;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0419.bmp")]
        public static byte[] test_image419;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0420.bmp")]
        public static byte[] test_image420;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0421.bmp")]
        public static byte[] test_image421;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0422.bmp")]
        public static byte[] test_image422;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0423.bmp")]
        public static byte[] test_image423;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0424.bmp")]
        public static byte[] test_image424;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0425.bmp")]
        public static byte[] test_image425;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0426.bmp")]
        public static byte[] test_image426;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0427.bmp")]
        public static byte[] test_image427;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0428.bmp")]
        public static byte[] test_image428;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0429.bmp")]
        public static byte[] test_image429;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0430.bmp")]
        public static byte[] test_image430;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0431.bmp")]
        public static byte[] test_image431;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0432.bmp")]
        public static byte[] test_image432;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0433.bmp")]
        public static byte[] test_image433;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0434.bmp")]
        public static byte[] test_image434;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0435.bmp")]
        public static byte[] test_image435;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0436.bmp")]
        public static byte[] test_image436;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0437.bmp")]
        public static byte[] test_image437;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0438.bmp")]
        public static byte[] test_image438;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0439.bmp")]
        public static byte[] test_image439;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0440.bmp")]
        public static byte[] test_image440;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0441.bmp")]
        public static byte[] test_image441;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0442.bmp")]
        public static byte[] test_image442;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0443.bmp")]
        public static byte[] test_image443;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0444.bmp")]
        public static byte[] test_image444;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0445.bmp")]
        public static byte[] test_image445;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0446.bmp")]
        public static byte[] test_image446;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0447.bmp")]
        public static byte[] test_image447;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0448.bmp")]
        public static byte[] test_image448;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0449.bmp")]
        public static byte[] test_image449;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0450.bmp")]
        public static byte[] test_image450;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0451.bmp")]
        public static byte[] test_image451;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0452.bmp")]
        public static byte[] test_image452;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0453.bmp")]
        public static byte[] test_image453;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0454.bmp")]
        public static byte[] test_image454;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0455.bmp")]
        public static byte[] test_image455;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0456.bmp")]
        public static byte[] test_image456;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0457.bmp")]
        public static byte[] test_image457;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0458.bmp")]
        public static byte[] test_image458;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0459.bmp")]
        public static byte[] test_image459;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0460.bmp")]
        public static byte[] test_image460;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0461.bmp")]
        public static byte[] test_image461;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0462.bmp")]
        public static byte[] test_image462;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0463.bmp")]
        public static byte[] test_image463;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0464.bmp")]
        public static byte[] test_image464;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0465.bmp")]
        public static byte[] test_image465;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0466.bmp")]
        public static byte[] test_image466;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0467.bmp")]
        public static byte[] test_image467;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0468.bmp")]
        public static byte[] test_image468;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0469.bmp")]
        public static byte[] test_image469;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0470.bmp")]
        public static byte[] test_image470;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0471.bmp")]
        public static byte[] test_image471;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0472.bmp")]
        public static byte[] test_image472;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0473.bmp")]
        public static byte[] test_image473;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0474.bmp")]
        public static byte[] test_image474;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0475.bmp")]
        public static byte[] test_image475;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0476.bmp")]
        public static byte[] test_image476;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0477.bmp")]
        public static byte[] test_image477;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0478.bmp")]
        public static byte[] test_image478;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0479.bmp")]
        public static byte[] test_image479;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0480.bmp")]
        public static byte[] test_image480;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0481.bmp")]
        public static byte[] test_image481;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0482.bmp")]
        public static byte[] test_image482;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0483.bmp")]
        public static byte[] test_image483;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0484.bmp")]
        public static byte[] test_image484;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0485.bmp")]
        public static byte[] test_image485;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0486.bmp")]
        public static byte[] test_image486;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0487.bmp")]
        public static byte[] test_image487;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0488.bmp")]
        public static byte[] test_image488;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0489.bmp")]
        public static byte[] test_image489;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0490.bmp")]
        public static byte[] test_image490;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0491.bmp")]
        public static byte[] test_image491;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0492.bmp")]
        public static byte[] test_image492;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0493.bmp")]
        public static byte[] test_image493;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0494.bmp")]
        public static byte[] test_image494;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0495.bmp")]
        public static byte[] test_image495;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0496.bmp")]
        public static byte[] test_image496;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0497.bmp")]
        public static byte[] test_image497;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0498.bmp")]
        public static byte[] test_image498;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0499.bmp")]
        public static byte[] test_image499;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0500.bmp")]
        public static byte[] test_image500;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0501.bmp")]
        public static byte[] test_image501;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0502.bmp")]
        public static byte[] test_image502;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0503.bmp")]
        public static byte[] test_image503;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0504.bmp")]
        public static byte[] test_image504;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0505.bmp")]
        public static byte[] test_image505;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0506.bmp")]
        public static byte[] test_image506;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0507.bmp")]
        public static byte[] test_image507;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0508.bmp")]
        public static byte[] test_image508;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0509.bmp")]
        public static byte[] test_image509;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0510.bmp")]
        public static byte[] test_image510;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0511.bmp")]
        public static byte[] test_image511;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0512.bmp")]
        public static byte[] test_image512;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0513.bmp")]
        public static byte[] test_image513;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0514.bmp")]
        public static byte[] test_image514;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0515.bmp")]
        public static byte[] test_image515;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0516.bmp")]
        public static byte[] test_image516;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0517.bmp")]
        public static byte[] test_image517;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0518.bmp")]
        public static byte[] test_image518;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0519.bmp")]
        public static byte[] test_image519;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0520.bmp")]
        public static byte[] test_image520;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0521.bmp")]
        public static byte[] test_image521;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0522.bmp")]
        public static byte[] test_image522;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0523.bmp")]
        public static byte[] test_image523;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0524.bmp")]
        public static byte[] test_image524;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0525.bmp")]
        public static byte[] test_image525;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0526.bmp")]
        public static byte[] test_image526;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0527.bmp")]
        public static byte[] test_image527;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0528.bmp")]
        public static byte[] test_image528;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0529.bmp")]
        public static byte[] test_image529;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0530.bmp")]
        public static byte[] test_image530;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0531.bmp")]
        public static byte[] test_image531;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0532.bmp")]
        public static byte[] test_image532;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0533.bmp")]
        public static byte[] test_image533;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0534.bmp")]
        public static byte[] test_image534;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0535.bmp")]
        public static byte[] test_image535;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0536.bmp")]
        public static byte[] test_image536;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0537.bmp")]
        public static byte[] test_image537;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0538.bmp")]
        public static byte[] test_image538;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0539.bmp")]
        public static byte[] test_image539;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0540.bmp")]
        public static byte[] test_image540;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0541.bmp")]
        public static byte[] test_image541;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0542.bmp")]
        public static byte[] test_image542;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0543.bmp")]
        public static byte[] test_image543;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0544.bmp")]
        public static byte[] test_image544;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0545.bmp")]
        public static byte[] test_image545;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0546.bmp")]
        public static byte[] test_image546;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0547.bmp")]
        public static byte[] test_image547;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0548.bmp")]
        public static byte[] test_image548;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0549.bmp")]
        public static byte[] test_image549;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0550.bmp")]
        public static byte[] test_image550;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0551.bmp")]
        public static byte[] test_image551;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0552.bmp")]
        public static byte[] test_image552;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0553.bmp")]
        public static byte[] test_image553;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0554.bmp")]
        public static byte[] test_image554;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0555.bmp")]
        public static byte[] test_image555;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0556.bmp")]
        public static byte[] test_image556;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0557.bmp")]
        public static byte[] test_image557;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0558.bmp")]
        public static byte[] test_image558;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0559.bmp")]
        public static byte[] test_image559;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0560.bmp")]
        public static byte[] test_image560;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0561.bmp")]
        public static byte[] test_image561;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0562.bmp")]
        public static byte[] test_image562;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0563.bmp")]
        public static byte[] test_image563;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0564.bmp")]
        public static byte[] test_image564;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0565.bmp")]
        public static byte[] test_image565;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0566.bmp")]
        public static byte[] test_image566;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0567.bmp")]
        public static byte[] test_image567;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0568.bmp")]
        public static byte[] test_image568;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0569.bmp")]
        public static byte[] test_image569;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0570.bmp")]
        public static byte[] test_image570;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0571.bmp")]
        public static byte[] test_image571;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0572.bmp")]
        public static byte[] test_image572;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0573.bmp")]
        public static byte[] test_image573;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0574.bmp")]
        public static byte[] test_image574;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0575.bmp")]
        public static byte[] test_image575;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0576.bmp")]
        public static byte[] test_image576;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0577.bmp")]
        public static byte[] test_image577;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0578.bmp")]
        public static byte[] test_image578;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0579.bmp")]
        public static byte[] test_image579;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0580.bmp")]
        public static byte[] test_image580;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0581.bmp")]
        public static byte[] test_image581;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0582.bmp")]
        public static byte[] test_image582;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0583.bmp")]
        public static byte[] test_image583;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0584.bmp")]
        public static byte[] test_image584;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0585.bmp")]
        public static byte[] test_image585;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0586.bmp")]
        public static byte[] test_image586;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0587.bmp")]
        public static byte[] test_image587;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0588.bmp")]
        public static byte[] test_image588;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0589.bmp")]
        public static byte[] test_image589;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0590.bmp")]
        public static byte[] test_image590;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0591.bmp")]
        public static byte[] test_image591;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0592.bmp")]
        public static byte[] test_image592;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0593.bmp")]
        public static byte[] test_image593;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0594.bmp")]
        public static byte[] test_image594;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0595.bmp")]
        public static byte[] test_image595;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0596.bmp")]
        public static byte[] test_image596;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0597.bmp")]
        public static byte[] test_image597;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0598.bmp")]
        public static byte[] test_image598;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0599.bmp")]
        public static byte[] test_image599;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0600.bmp")]
        public static byte[] test_image600;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0601.bmp")]
        public static byte[] test_image601;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0602.bmp")]
        public static byte[] test_image602;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0603.bmp")]
        public static byte[] test_image603;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0604.bmp")]
        public static byte[] test_image604;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0605.bmp")]
        public static byte[] test_image605;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0606.bmp")]
        public static byte[] test_image606;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0607.bmp")]
        public static byte[] test_image607;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0608.bmp")]
        public static byte[] test_image608;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0609.bmp")]
        public static byte[] test_image609;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0610.bmp")]
        public static byte[] test_image610;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0611.bmp")]
        public static byte[] test_image611;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0612.bmp")]
        public static byte[] test_image612;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0613.bmp")]
        public static byte[] test_image613;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0614.bmp")]
        public static byte[] test_image614;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0615.bmp")]
        public static byte[] test_image615;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0616.bmp")]
        public static byte[] test_image616;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0617.bmp")]
        public static byte[] test_image617;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0618.bmp")]
        public static byte[] test_image618;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0619.bmp")]
        public static byte[] test_image619;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0620.bmp")]
        public static byte[] test_image620;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0621.bmp")]
        public static byte[] test_image621;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0622.bmp")]
        public static byte[] test_image622;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0623.bmp")]
        public static byte[] test_image623;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0624.bmp")]
        public static byte[] test_image624;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0625.bmp")]
        public static byte[] test_image625;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0626.bmp")]
        public static byte[] test_image626;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0627.bmp")]
        public static byte[] test_image627;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0628.bmp")]
        public static byte[] test_image628;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0629.bmp")]
        public static byte[] test_image629;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0630.bmp")]
        public static byte[] test_image630;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0631.bmp")]
        public static byte[] test_image631;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0632.bmp")]
        public static byte[] test_image632;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0633.bmp")]
        public static byte[] test_image633;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0634.bmp")]
        public static byte[] test_image634;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0635.bmp")]
        public static byte[] test_image635;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0636.bmp")]
        public static byte[] test_image636;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0637.bmp")]
        public static byte[] test_image637;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0638.bmp")]
        public static byte[] test_image638;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0639.bmp")]
        public static byte[] test_image639;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0640.bmp")]
        public static byte[] test_image640;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0641.bmp")]
        public static byte[] test_image641;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0642.bmp")]
        public static byte[] test_image642;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0643.bmp")]
        public static byte[] test_image643;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0644.bmp")]
        public static byte[] test_image644;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0645.bmp")]
        public static byte[] test_image645;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0646.bmp")]
        public static byte[] test_image646;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0647.bmp")]
        public static byte[] test_image647;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0648.bmp")]
        public static byte[] test_image648;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0649.bmp")]
        public static byte[] test_image649;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0650.bmp")]
        public static byte[] test_image650;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0651.bmp")]
        public static byte[] test_image651;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0652.bmp")]
        public static byte[] test_image652;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0653.bmp")]
        public static byte[] test_image653;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0654.bmp")]
        public static byte[] test_image654;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0655.bmp")]
        public static byte[] test_image655;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0656.bmp")]
        public static byte[] test_image656;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0657.bmp")]
        public static byte[] test_image657;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0658.bmp")]
        public static byte[] test_image658;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0659.bmp")]
        public static byte[] test_image659;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0660.bmp")]
        public static byte[] test_image660;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0661.bmp")]
        public static byte[] test_image661;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0662.bmp")]
        public static byte[] test_image662;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0663.bmp")]
        public static byte[] test_image663;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0664.bmp")]
        public static byte[] test_image664;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0665.bmp")]
        public static byte[] test_image665;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0666.bmp")]
        public static byte[] test_image666;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0667.bmp")]
        public static byte[] test_image667;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0668.bmp")]
        public static byte[] test_image668;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0669.bmp")]
        public static byte[] test_image669;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0670.bmp")]
        public static byte[] test_image670;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0671.bmp")]
        public static byte[] test_image671;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0672.bmp")]
        public static byte[] test_image672;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0673.bmp")]
        public static byte[] test_image673;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0674.bmp")]
        public static byte[] test_image674;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0675.bmp")]
        public static byte[] test_image675;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0676.bmp")]
        public static byte[] test_image676;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0677.bmp")]
        public static byte[] test_image677;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0678.bmp")]
        public static byte[] test_image678;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0679.bmp")]
        public static byte[] test_image679;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0680.bmp")]
        public static byte[] test_image680;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0681.bmp")]
        public static byte[] test_image681;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0682.bmp")]
        public static byte[] test_image682;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0683.bmp")]
        public static byte[] test_image683;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0684.bmp")]
        public static byte[] test_image684;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0685.bmp")]
        public static byte[] test_image685;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0686.bmp")]
        public static byte[] test_image686;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0687.bmp")]
        public static byte[] test_image687;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0688.bmp")]
        public static byte[] test_image688;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0689.bmp")]
        public static byte[] test_image689;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0690.bmp")]
        public static byte[] test_image690;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0691.bmp")]
        public static byte[] test_image691;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0692.bmp")]
        public static byte[] test_image692;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0693.bmp")]
        public static byte[] test_image693;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0694.bmp")]
        public static byte[] test_image694;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0695.bmp")]
        public static byte[] test_image695;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0696.bmp")]
        public static byte[] test_image696;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0697.bmp")]
        public static byte[] test_image697;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0698.bmp")]
        public static byte[] test_image698;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0699.bmp")]
        public static byte[] test_image699;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0700.bmp")]
        public static byte[] test_image700;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0701.bmp")]
        public static byte[] test_image701;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0702.bmp")]
        public static byte[] test_image702;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0703.bmp")]
        public static byte[] test_image703;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0704.bmp")]
        public static byte[] test_image704;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0705.bmp")]
        public static byte[] test_image705;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0706.bmp")]
        public static byte[] test_image706;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0707.bmp")]
        public static byte[] test_image707;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0708.bmp")]
        public static byte[] test_image708;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0709.bmp")]
        public static byte[] test_image709;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0710.bmp")]
        public static byte[] test_image710;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0711.bmp")]
        public static byte[] test_image711;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0712.bmp")]
        public static byte[] test_image712;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0713.bmp")]
        public static byte[] test_image713;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0714.bmp")]
        public static byte[] test_image714;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0715.bmp")]
        public static byte[] test_image715;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0716.bmp")]
        public static byte[] test_image716;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0717.bmp")]
        public static byte[] test_image717;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0718.bmp")]
        public static byte[] test_image718;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0719.bmp")]
        public static byte[] test_image719;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0720.bmp")]
        public static byte[] test_image720;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0721.bmp")]
        public static byte[] test_image721;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0722.bmp")]
        public static byte[] test_image722;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0723.bmp")]
        public static byte[] test_image723;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0724.bmp")]
        public static byte[] test_image724;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0725.bmp")]
        public static byte[] test_image725;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0726.bmp")]
        public static byte[] test_image726;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0727.bmp")]
        public static byte[] test_image727;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0728.bmp")]
        public static byte[] test_image728;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0729.bmp")]
        public static byte[] test_image729;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0730.bmp")]
        public static byte[] test_image730;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0731.bmp")]
        public static byte[] test_image731;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0732.bmp")]
        public static byte[] test_image732;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0733.bmp")]
        public static byte[] test_image733;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0734.bmp")]
        public static byte[] test_image734;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0735.bmp")]
        public static byte[] test_image735;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0736.bmp")]
        public static byte[] test_image736;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0737.bmp")]
        public static byte[] test_image737;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0738.bmp")]
        public static byte[] test_image738;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0739.bmp")]
        public static byte[] test_image739;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0740.bmp")]
        public static byte[] test_image740;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0741.bmp")]
        public static byte[] test_image741;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0742.bmp")]
        public static byte[] test_image742;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0743.bmp")]
        public static byte[] test_image743;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0744.bmp")]
        public static byte[] test_image744;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0745.bmp")]
        public static byte[] test_image745;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0746.bmp")]
        public static byte[] test_image746;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0747.bmp")]
        public static byte[] test_image747;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0748.bmp")]
        public static byte[] test_image748;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0749.bmp")]
        public static byte[] test_image749;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0750.bmp")]
        public static byte[] test_image750;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0751.bmp")]
        public static byte[] test_image751;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0752.bmp")]
        public static byte[] test_image752;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0753.bmp")]
        public static byte[] test_image753;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0754.bmp")]
        public static byte[] test_image754;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0755.bmp")]
        public static byte[] test_image755;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0756.bmp")]
        public static byte[] test_image756;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0757.bmp")]
        public static byte[] test_image757;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0758.bmp")]
        public static byte[] test_image758;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0759.bmp")]
        public static byte[] test_image759;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0760.bmp")]
        public static byte[] test_image760;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0761.bmp")]
        public static byte[] test_image761;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0762.bmp")]
        public static byte[] test_image762;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0763.bmp")]
        public static byte[] test_image763;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0764.bmp")]
        public static byte[] test_image764;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0765.bmp")]
        public static byte[] test_image765;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0766.bmp")]
        public static byte[] test_image766;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0767.bmp")]
        public static byte[] test_image767;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0768.bmp")]
        public static byte[] test_image768;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0769.bmp")]
        public static byte[] test_image769;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0770.bmp")]
        public static byte[] test_image770;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0771.bmp")]
        public static byte[] test_image771;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0772.bmp")]
        public static byte[] test_image772;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0773.bmp")]
        public static byte[] test_image773;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0774.bmp")]
        public static byte[] test_image774;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0775.bmp")]
        public static byte[] test_image775;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0776.bmp")]
        public static byte[] test_image776;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0777.bmp")]
        public static byte[] test_image777;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0778.bmp")]
        public static byte[] test_image778;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0779.bmp")]
        public static byte[] test_image779;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0780.bmp")]
        public static byte[] test_image780;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0781.bmp")]
        public static byte[] test_image781;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0782.bmp")]
        public static byte[] test_image782;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0783.bmp")]
        public static byte[] test_image783;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0784.bmp")]
        public static byte[] test_image784;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0785.bmp")]
        public static byte[] test_image785;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0786.bmp")]
        public static byte[] test_image786;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0787.bmp")]
        public static byte[] test_image787;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0788.bmp")]
        public static byte[] test_image788;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0789.bmp")]
        public static byte[] test_image789;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0790.bmp")]
        public static byte[] test_image790;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0791.bmp")]
        public static byte[] test_image791;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0792.bmp")]
        public static byte[] test_image792;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0793.bmp")]
        public static byte[] test_image793;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0794.bmp")]
        public static byte[] test_image794;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0795.bmp")]
        public static byte[] test_image795;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0796.bmp")]
        public static byte[] test_image796;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0797.bmp")]
        public static byte[] test_image797;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0798.bmp")]
        public static byte[] test_image798;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0799.bmp")]
        public static byte[] test_image799;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0800.bmp")]
        public static byte[] test_image800;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0801.bmp")]
        public static byte[] test_image801;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0802.bmp")]
        public static byte[] test_image802;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0803.bmp")]
        public static byte[] test_image803;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0804.bmp")]
        public static byte[] test_image804;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0805.bmp")]
        public static byte[] test_image805;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0806.bmp")]
        public static byte[] test_image806;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0807.bmp")]
        public static byte[] test_image807;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0808.bmp")]
        public static byte[] test_image808;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0809.bmp")]
        public static byte[] test_image809;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0810.bmp")]
        public static byte[] test_image810;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0811.bmp")]
        public static byte[] test_image811;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0812.bmp")]
        public static byte[] test_image812;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0813.bmp")]
        public static byte[] test_image813;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0814.bmp")]
        public static byte[] test_image814;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0815.bmp")]
        public static byte[] test_image815;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0816.bmp")]
        public static byte[] test_image816;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0817.bmp")]
        public static byte[] test_image817;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0818.bmp")]
        public static byte[] test_image818;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0819.bmp")]
        public static byte[] test_image819;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0820.bmp")]
        public static byte[] test_image820;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0821.bmp")]
        public static byte[] test_image821;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0822.bmp")]
        public static byte[] test_image822;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0823.bmp")]
        public static byte[] test_image823;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0824.bmp")]
        public static byte[] test_image824;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0825.bmp")]
        public static byte[] test_image825;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0826.bmp")]
        public static byte[] test_image826;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0827.bmp")]
        public static byte[] test_image827;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0828.bmp")]
        public static byte[] test_image828;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0829.bmp")]
        public static byte[] test_image829;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0830.bmp")]
        public static byte[] test_image830;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0831.bmp")]
        public static byte[] test_image831;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0832.bmp")]
        public static byte[] test_image832;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0833.bmp")]
        public static byte[] test_image833;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0834.bmp")]
        public static byte[] test_image834;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0835.bmp")]
        public static byte[] test_image835;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0836.bmp")]
        public static byte[] test_image836;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0837.bmp")]
        public static byte[] test_image837;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0838.bmp")]
        public static byte[] test_image838;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0839.bmp")]
        public static byte[] test_image839;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0840.bmp")]
        public static byte[] test_image840;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0841.bmp")]
        public static byte[] test_image841;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0842.bmp")]
        public static byte[] test_image842;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0843.bmp")]
        public static byte[] test_image843;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0844.bmp")]
        public static byte[] test_image844;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0845.bmp")]
        public static byte[] test_image845;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0846.bmp")]
        public static byte[] test_image846;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0847.bmp")]
        public static byte[] test_image847;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0848.bmp")]
        public static byte[] test_image848;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0849.bmp")]
        public static byte[] test_image849;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0850.bmp")]
        public static byte[] test_image850;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0851.bmp")]
        public static byte[] test_image851;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0852.bmp")]
        public static byte[] test_image852;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0853.bmp")]
        public static byte[] test_image853;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0854.bmp")]
        public static byte[] test_image854;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0855.bmp")]
        public static byte[] test_image855;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0856.bmp")]
        public static byte[] test_image856;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0857.bmp")]
        public static byte[] test_image857;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0858.bmp")]
        public static byte[] test_image858;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0859.bmp")]
        public static byte[] test_image859;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0860.bmp")]
        public static byte[] test_image860;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0861.bmp")]
        public static byte[] test_image861;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0862.bmp")]
        public static byte[] test_image862;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0863.bmp")]
        public static byte[] test_image863;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0864.bmp")]
        public static byte[] test_image864;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0865.bmp")]
        public static byte[] test_image865;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0866.bmp")]
        public static byte[] test_image866;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0867.bmp")]
        public static byte[] test_image867;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0868.bmp")]
        public static byte[] test_image868;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0869.bmp")]
        public static byte[] test_image869;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0870.bmp")]
        public static byte[] test_image870;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0871.bmp")]
        public static byte[] test_image871;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0872.bmp")]
        public static byte[] test_image872;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0873.bmp")]
        public static byte[] test_image873;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0874.bmp")]
        public static byte[] test_image874;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0875.bmp")]
        public static byte[] test_image875;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0876.bmp")]
        public static byte[] test_image876;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0877.bmp")]
        public static byte[] test_image877;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0878.bmp")]
        public static byte[] test_image878;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0879.bmp")]
        public static byte[] test_image879;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0880.bmp")]
        public static byte[] test_image880;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0881.bmp")]
        public static byte[] test_image881;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0882.bmp")]
        public static byte[] test_image882;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0883.bmp")]
        public static byte[] test_image883;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0884.bmp")]
        public static byte[] test_image884;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0885.bmp")]
        public static byte[] test_image885;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0886.bmp")]
        public static byte[] test_image886;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0887.bmp")]
        public static byte[] test_image887;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0888.bmp")]
        public static byte[] test_image888;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0889.bmp")]
        public static byte[] test_image889;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0890.bmp")]
        public static byte[] test_image890;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0891.bmp")]
        public static byte[] test_image891;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0892.bmp")]
        public static byte[] test_image892;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0893.bmp")]
        public static byte[] test_image893;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0894.bmp")]
        public static byte[] test_image894;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0895.bmp")]
        public static byte[] test_image895;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0896.bmp")]
        public static byte[] test_image896;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0897.bmp")]
        public static byte[] test_image897;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0898.bmp")]
        public static byte[] test_image898;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0899.bmp")]
        public static byte[] test_image899;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0900.bmp")]
        public static byte[] test_image900;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0901.bmp")]
        public static byte[] test_image901;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0902.bmp")]
        public static byte[] test_image902;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0903.bmp")]
        public static byte[] test_image903;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0904.bmp")]
        public static byte[] test_image904;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0905.bmp")]
        public static byte[] test_image905;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0906.bmp")]
        public static byte[] test_image906;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0907.bmp")]
        public static byte[] test_image907;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0908.bmp")]
        public static byte[] test_image908;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0909.bmp")]
        public static byte[] test_image909;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0910.bmp")]
        public static byte[] test_image910;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0911.bmp")]
        public static byte[] test_image911;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0912.bmp")]
        public static byte[] test_image912;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0913.bmp")]
        public static byte[] test_image913;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0914.bmp")]
        public static byte[] test_image914;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0915.bmp")]
        public static byte[] test_image915;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0916.bmp")]
        public static byte[] test_image916;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0917.bmp")]
        public static byte[] test_image917;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0918.bmp")]
        public static byte[] test_image918;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0919.bmp")]
        public static byte[] test_image919;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0920.bmp")]
        public static byte[] test_image920;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0921.bmp")]
        public static byte[] test_image921;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0922.bmp")]
        public static byte[] test_image922;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0923.bmp")]
        public static byte[] test_image923;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0924.bmp")]
        public static byte[] test_image924;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0925.bmp")]
        public static byte[] test_image925;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0926.bmp")]
        public static byte[] test_image926;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0927.bmp")]
        public static byte[] test_image927;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0928.bmp")]
        public static byte[] test_image928;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0929.bmp")]
        public static byte[] test_image929;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0930.bmp")]
        public static byte[] test_image930;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0931.bmp")]
        public static byte[] test_image931;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0932.bmp")]
        public static byte[] test_image932;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0933.bmp")]
        public static byte[] test_image933;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0934.bmp")]
        public static byte[] test_image934;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0935.bmp")]
        public static byte[] test_image935;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0936.bmp")]
        public static byte[] test_image936;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0937.bmp")]
        public static byte[] test_image937;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0938.bmp")]
        public static byte[] test_image938;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0939.bmp")]
        public static byte[] test_image939;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0940.bmp")]
        public static byte[] test_image940;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0941.bmp")]
        public static byte[] test_image941;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0942.bmp")]
        public static byte[] test_image942;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0943.bmp")]
        public static byte[] test_image943;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0944.bmp")]
        public static byte[] test_image944;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0945.bmp")]
        public static byte[] test_image945;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0946.bmp")]
        public static byte[] test_image946;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0947.bmp")]
        public static byte[] test_image947;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0948.bmp")]
        public static byte[] test_image948;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0949.bmp")]
        public static byte[] test_image949;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0950.bmp")]
        public static byte[] test_image950;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0951.bmp")]
        public static byte[] test_image951;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0952.bmp")]
        public static byte[] test_image952;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0953.bmp")]
        public static byte[] test_image953;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0954.bmp")]
        public static byte[] test_image954;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0955.bmp")]
        public static byte[] test_image955;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0956.bmp")]
        public static byte[] test_image956;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0957.bmp")]
        public static byte[] test_image957;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0958.bmp")]
        public static byte[] test_image958;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0959.bmp")]
        public static byte[] test_image959;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0960.bmp")]
        public static byte[] test_image960;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0961.bmp")]
        public static byte[] test_image961;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0962.bmp")]
        public static byte[] test_image962;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0963.bmp")]
        public static byte[] test_image963;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0964.bmp")]
        public static byte[] test_image964;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0965.bmp")]
        public static byte[] test_image965;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0966.bmp")]
        public static byte[] test_image966;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0967.bmp")]
        public static byte[] test_image967;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0968.bmp")]
        public static byte[] test_image968;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0969.bmp")]
        public static byte[] test_image969;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0970.bmp")]
        public static byte[] test_image970;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0971.bmp")]
        public static byte[] test_image971;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0972.bmp")]
        public static byte[] test_image972;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0973.bmp")]
        public static byte[] test_image973;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0974.bmp")]
        public static byte[] test_image974;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0975.bmp")]
        public static byte[] test_image975;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0976.bmp")]
        public static byte[] test_image976;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0977.bmp")]
        public static byte[] test_image977;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0978.bmp")]
        public static byte[] test_image978;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0979.bmp")]
        public static byte[] test_image979;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0980.bmp")]
        public static byte[] test_image980;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0981.bmp")]
        public static byte[] test_image981;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0982.bmp")]
        public static byte[] test_image982;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0983.bmp")]
        public static byte[] test_image983;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0984.bmp")]
        public static byte[] test_image984;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0985.bmp")]
        public static byte[] test_image985;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0986.bmp")]
        public static byte[] test_image986;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0987.bmp")]
        public static byte[] test_image987;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0988.bmp")]
        public static byte[] test_image988;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0989.bmp")]
        public static byte[] test_image989;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0990.bmp")]
        public static byte[] test_image990;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0991.bmp")]
        public static byte[] test_image991;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0992.bmp")]
        public static byte[] test_image992;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0993.bmp")]
        public static byte[] test_image993;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0994.bmp")]
        public static byte[] test_image994;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0995.bmp")]
        public static byte[] test_image995;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0996.bmp")]
        public static byte[] test_image996;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0997.bmp")]
        public static byte[] test_image997;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0998.bmp")]
        public static byte[] test_image998;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_0999.bmp")]
        public static byte[] test_image999;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1000.bmp")]
        public static byte[] test_image1000;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1001.bmp")]
        public static byte[] test_image1001;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1002.bmp")]
        public static byte[] test_image1002;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1003.bmp")]
        public static byte[] test_image1003;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1004.bmp")]
        public static byte[] test_image1004;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1005.bmp")]
        public static byte[] test_image1005;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1006.bmp")]
        public static byte[] test_image1006;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1007.bmp")]
        public static byte[] test_image1007;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1008.bmp")]
        public static byte[] test_image1008;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1009.bmp")]
        public static byte[] test_image1009;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1010.bmp")]
        public static byte[] test_image1010;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1011.bmp")]
        public static byte[] test_image1011;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1012.bmp")]
        public static byte[] test_image1012;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1013.bmp")]
        public static byte[] test_image1013;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1014.bmp")]
        public static byte[] test_image1014;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1015.bmp")]
        public static byte[] test_image1015;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1016.bmp")]
        public static byte[] test_image1016;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1017.bmp")]
        public static byte[] test_image1017;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1018.bmp")]
        public static byte[] test_image1018;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1019.bmp")]
        public static byte[] test_image1019;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1020.bmp")]
        public static byte[] test_image1020;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1021.bmp")]
        public static byte[] test_image1021;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1022.bmp")]
        public static byte[] test_image1022;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1023.bmp")]
        public static byte[] test_image1023;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1024.bmp")]
        public static byte[] test_image1024;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1025.bmp")]
        public static byte[] test_image1025;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1026.bmp")]
        public static byte[] test_image1026;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1027.bmp")]
        public static byte[] test_image1027;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1028.bmp")]
        public static byte[] test_image1028;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1029.bmp")]
        public static byte[] test_image1029;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1030.bmp")]
        public static byte[] test_image1030;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1031.bmp")]
        public static byte[] test_image1031;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1032.bmp")]
        public static byte[] test_image1032;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1033.bmp")]
        public static byte[] test_image1033;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1034.bmp")]
        public static byte[] test_image1034;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1035.bmp")]
        public static byte[] test_image1035;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1036.bmp")]
        public static byte[] test_image1036;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1037.bmp")]
        public static byte[] test_image1037;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1038.bmp")]
        public static byte[] test_image1038;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1039.bmp")]
        public static byte[] test_image1039;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1040.bmp")]
        public static byte[] test_image1040;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1041.bmp")]
        public static byte[] test_image1041;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1042.bmp")]
        public static byte[] test_image1042;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1043.bmp")]
        public static byte[] test_image1043;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1044.bmp")]
        public static byte[] test_image1044;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1045.bmp")]
        public static byte[] test_image1045;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1046.bmp")]
        public static byte[] test_image1046;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1047.bmp")]
        public static byte[] test_image1047;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1048.bmp")]
        public static byte[] test_image1048;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1049.bmp")]
        public static byte[] test_image1049;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1050.bmp")]
        public static byte[] test_image1050;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1051.bmp")]
        public static byte[] test_image1051;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1052.bmp")]
        public static byte[] test_image1052;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1053.bmp")]
        public static byte[] test_image1053;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1054.bmp")]
        public static byte[] test_image1054;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1055.bmp")]
        public static byte[] test_image1055;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1056.bmp")]
        public static byte[] test_image1056;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1057.bmp")]
        public static byte[] test_image1057;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1058.bmp")]
        public static byte[] test_image1058;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1059.bmp")]
        public static byte[] test_image1059;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1060.bmp")]
        public static byte[] test_image1060;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1061.bmp")]
        public static byte[] test_image1061;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1062.bmp")]
        public static byte[] test_image1062;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1063.bmp")]
        public static byte[] test_image1063;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1064.bmp")]
        public static byte[] test_image1064;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1065.bmp")]
        public static byte[] test_image1065;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1066.bmp")]
        public static byte[] test_image1066;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1067.bmp")]
        public static byte[] test_image1067;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1068.bmp")]
        public static byte[] test_image1068;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1069.bmp")]
        public static byte[] test_image1069;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1070.bmp")]
        public static byte[] test_image1070;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1071.bmp")]
        public static byte[] test_image1071;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1072.bmp")]
        public static byte[] test_image1072;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1073.bmp")]
        public static byte[] test_image1073;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1074.bmp")]
        public static byte[] test_image1074;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1075.bmp")]
        public static byte[] test_image1075;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1076.bmp")]
        public static byte[] test_image1076;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1077.bmp")]
        public static byte[] test_image1077;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1078.bmp")]
        public static byte[] test_image1078;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1079.bmp")]
        public static byte[] test_image1079;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1080.bmp")]
        public static byte[] test_image1080;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1081.bmp")]
        public static byte[] test_image1081;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1082.bmp")]
        public static byte[] test_image1082;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1083.bmp")]
        public static byte[] test_image1083;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1084.bmp")]
        public static byte[] test_image1084;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1085.bmp")]
        public static byte[] test_image1085;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1086.bmp")]
        public static byte[] test_image1086;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1087.bmp")]
        public static byte[] test_image1087;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1088.bmp")]
        public static byte[] test_image1088;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1089.bmp")]
        public static byte[] test_image1089;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1090.bmp")]
        public static byte[] test_image1090;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1091.bmp")]
        public static byte[] test_image1091;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1092.bmp")]
        public static byte[] test_image1092;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1093.bmp")]
        public static byte[] test_image1093;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1094.bmp")]
        public static byte[] test_image1094;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1095.bmp")]
        public static byte[] test_image1095;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1096.bmp")]
        public static byte[] test_image1096;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1097.bmp")]
        public static byte[] test_image1097;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1098.bmp")]
        public static byte[] test_image1098;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1099.bmp")]
        public static byte[] test_image1099;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1100.bmp")]
        public static byte[] test_image1100;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1101.bmp")]
        public static byte[] test_image1101;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1102.bmp")]
        public static byte[] test_image1102;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1103.bmp")]
        public static byte[] test_image1103;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1104.bmp")]
        public static byte[] test_image1104;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1105.bmp")]
        public static byte[] test_image1105;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1106.bmp")]
        public static byte[] test_image1106;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1107.bmp")]
        public static byte[] test_image1107;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1108.bmp")]
        public static byte[] test_image1108;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1109.bmp")]
        public static byte[] test_image1109;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1110.bmp")]
        public static byte[] test_image1110;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1111.bmp")]
        public static byte[] test_image1111;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1112.bmp")]
        public static byte[] test_image1112;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1113.bmp")]
        public static byte[] test_image1113;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1114.bmp")]
        public static byte[] test_image1114;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1115.bmp")]
        public static byte[] test_image1115;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1116.bmp")]
        public static byte[] test_image1116;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1117.bmp")]
        public static byte[] test_image1117;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1118.bmp")]
        public static byte[] test_image1118;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1119.bmp")]
        public static byte[] test_image1119;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1120.bmp")]
        public static byte[] test_image1120;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1121.bmp")]
        public static byte[] test_image1121;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1122.bmp")]
        public static byte[] test_image1122;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1123.bmp")]
        public static byte[] test_image1123;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1124.bmp")]
        public static byte[] test_image1124;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1125.bmp")]
        public static byte[] test_image1125;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1126.bmp")]
        public static byte[] test_image1126;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1127.bmp")]
        public static byte[] test_image1127;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1128.bmp")]
        public static byte[] test_image1128;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1129.bmp")]
        public static byte[] test_image1129;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1130.bmp")]
        public static byte[] test_image1130;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1131.bmp")]
        public static byte[] test_image1131;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1132.bmp")]
        public static byte[] test_image1132;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1133.bmp")]
        public static byte[] test_image1133;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1134.bmp")]
        public static byte[] test_image1134;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1135.bmp")]
        public static byte[] test_image1135;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1136.bmp")]
        public static byte[] test_image1136;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1137.bmp")]
        public static byte[] test_image1137;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1138.bmp")]
        public static byte[] test_image1138;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1139.bmp")]
        public static byte[] test_image1139;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1140.bmp")]
        public static byte[] test_image1140;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1141.bmp")]
        public static byte[] test_image1141;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1142.bmp")]
        public static byte[] test_image1142;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1143.bmp")]
        public static byte[] test_image1143;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1144.bmp")]
        public static byte[] test_image1144;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1145.bmp")]
        public static byte[] test_image1145;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1146.bmp")]
        public static byte[] test_image1146;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1147.bmp")]
        public static byte[] test_image1147;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1148.bmp")]
        public static byte[] test_image1148;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1149.bmp")]
        public static byte[] test_image1149;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1150.bmp")]
        public static byte[] test_image1150;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1151.bmp")]
        public static byte[] test_image1151;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1152.bmp")]
        public static byte[] test_image1152;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1153.bmp")]
        public static byte[] test_image1153;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1154.bmp")]
        public static byte[] test_image1154;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1155.bmp")]
        public static byte[] test_image1155;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1156.bmp")]
        public static byte[] test_image1156;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1157.bmp")]
        public static byte[] test_image1157;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1158.bmp")]
        public static byte[] test_image1158;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1159.bmp")]
        public static byte[] test_image1159;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1160.bmp")]
        public static byte[] test_image1160;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1161.bmp")]
        public static byte[] test_image1161;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1162.bmp")]
        public static byte[] test_image1162;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1163.bmp")]
        public static byte[] test_image1163;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1164.bmp")]
        public static byte[] test_image1164;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1165.bmp")]
        public static byte[] test_image1165;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1166.bmp")]
        public static byte[] test_image1166;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1167.bmp")]
        public static byte[] test_image1167;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1168.bmp")]
        public static byte[] test_image1168;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1169.bmp")]
        public static byte[] test_image1169;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1170.bmp")]
        public static byte[] test_image1170;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1171.bmp")]
        public static byte[] test_image1171;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1172.bmp")]
        public static byte[] test_image1172;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1173.bmp")]
        public static byte[] test_image1173;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1174.bmp")]
        public static byte[] test_image1174;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1175.bmp")]
        public static byte[] test_image1175;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1176.bmp")]
        public static byte[] test_image1176;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1177.bmp")]
        public static byte[] test_image1177;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1178.bmp")]
        public static byte[] test_image1178;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1179.bmp")]
        public static byte[] test_image1179;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1180.bmp")]
        public static byte[] test_image1180;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1181.bmp")]
        public static byte[] test_image1181;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1182.bmp")]
        public static byte[] test_image1182;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1183.bmp")]
        public static byte[] test_image1183;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1184.bmp")]
        public static byte[] test_image1184;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1185.bmp")]
        public static byte[] test_image1185;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1186.bmp")]
        public static byte[] test_image1186;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1187.bmp")]
        public static byte[] test_image1187;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1188.bmp")]
        public static byte[] test_image1188;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1189.bmp")]
        public static byte[] test_image1189;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1190.bmp")]
        public static byte[] test_image1190;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1191.bmp")]
        public static byte[] test_image1191;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1192.bmp")]
        public static byte[] test_image1192;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1193.bmp")]
        public static byte[] test_image1193;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1194.bmp")]
        public static byte[] test_image1194;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1195.bmp")]
        public static byte[] test_image1195;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1196.bmp")]
        public static byte[] test_image1196;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1197.bmp")]
        public static byte[] test_image1197;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1198.bmp")]
        public static byte[] test_image1198;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1199.bmp")]
        public static byte[] test_image1199;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1200.bmp")]
        public static byte[] test_image1200;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1201.bmp")]
        public static byte[] test_image1201;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1202.bmp")]
        public static byte[] test_image1202;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1203.bmp")]
        public static byte[] test_image1203;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1204.bmp")]
        public static byte[] test_image1204;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1205.bmp")]
        public static byte[] test_image1205;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1206.bmp")]
        public static byte[] test_image1206;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1207.bmp")]
        public static byte[] test_image1207;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1208.bmp")]
        public static byte[] test_image1208;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1209.bmp")]
        public static byte[] test_image1209;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1210.bmp")]
        public static byte[] test_image1210;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1211.bmp")]
        public static byte[] test_image1211;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1212.bmp")]
        public static byte[] test_image1212;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1213.bmp")]
        public static byte[] test_image1213;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1214.bmp")]
        public static byte[] test_image1214;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1215.bmp")]
        public static byte[] test_image1215;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1216.bmp")]
        public static byte[] test_image1216;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1217.bmp")]
        public static byte[] test_image1217;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1218.bmp")]
        public static byte[] test_image1218;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1219.bmp")]
        public static byte[] test_image1219;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1220.bmp")]
        public static byte[] test_image1220;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1221.bmp")]
        public static byte[] test_image1221;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1222.bmp")]
        public static byte[] test_image1222;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1223.bmp")]
        public static byte[] test_image1223;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1224.bmp")]
        public static byte[] test_image1224;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1225.bmp")]
        public static byte[] test_image1225;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1226.bmp")]
        public static byte[] test_image1226;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1227.bmp")]
        public static byte[] test_image1227;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1228.bmp")]
        public static byte[] test_image1228;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1229.bmp")]
        public static byte[] test_image1229;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1230.bmp")]
        public static byte[] test_image1230;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1231.bmp")]
        public static byte[] test_image1231;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1232.bmp")]
        public static byte[] test_image1232;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1233.bmp")]
        public static byte[] test_image1233;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1234.bmp")]
        public static byte[] test_image1234;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1235.bmp")]
        public static byte[] test_image1235;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1236.bmp")]
        public static byte[] test_image1236;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1237.bmp")]
        public static byte[] test_image1237;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1238.bmp")]
        public static byte[] test_image1238;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1239.bmp")]
        public static byte[] test_image1239;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1240.bmp")]
        public static byte[] test_image1240;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1241.bmp")]
        public static byte[] test_image1241;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1242.bmp")]
        public static byte[] test_image1242;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1243.bmp")]
        public static byte[] test_image1243;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1244.bmp")]
        public static byte[] test_image1244;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1245.bmp")]
        public static byte[] test_image1245;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1246.bmp")]
        public static byte[] test_image1246;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1247.bmp")]
        public static byte[] test_image1247;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1248.bmp")]
        public static byte[] test_image1248;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1249.bmp")]
        public static byte[] test_image1249;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1250.bmp")]
        public static byte[] test_image1250;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1251.bmp")]
        public static byte[] test_image1251;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1252.bmp")]
        public static byte[] test_image1252;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1253.bmp")]
        public static byte[] test_image1253;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1254.bmp")]
        public static byte[] test_image1254;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1255.bmp")]
        public static byte[] test_image1255;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1256.bmp")]
        public static byte[] test_image1256;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1257.bmp")]
        public static byte[] test_image1257;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1258.bmp")]
        public static byte[] test_image1258;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1259.bmp")]
        public static byte[] test_image1259;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1260.bmp")]
        public static byte[] test_image1260;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1261.bmp")]
        public static byte[] test_image1261;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1262.bmp")]
        public static byte[] test_image1262;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1263.bmp")]
        public static byte[] test_image1263;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1264.bmp")]
        public static byte[] test_image1264;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1265.bmp")]
        public static byte[] test_image1265;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1266.bmp")]
        public static byte[] test_image1266;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1267.bmp")]
        public static byte[] test_image1267;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1268.bmp")]
        public static byte[] test_image1268;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1269.bmp")]
        public static byte[] test_image1269;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1270.bmp")]
        public static byte[] test_image1270;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1271.bmp")]
        public static byte[] test_image1271;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1272.bmp")]
        public static byte[] test_image1272;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1273.bmp")]
        public static byte[] test_image1273;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1274.bmp")]
        public static byte[] test_image1274;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1275.bmp")]
        public static byte[] test_image1275;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1276.bmp")]
        public static byte[] test_image1276;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1277.bmp")]
        public static byte[] test_image1277;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1278.bmp")]
        public static byte[] test_image1278;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1279.bmp")]
        public static byte[] test_image1279;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1280.bmp")]
        public static byte[] test_image1280;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1281.bmp")]
        public static byte[] test_image1281;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1282.bmp")]
        public static byte[] test_image1282;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1283.bmp")]
        public static byte[] test_image1283;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1284.bmp")]
        public static byte[] test_image1284;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1285.bmp")]
        public static byte[] test_image1285;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1286.bmp")]
        public static byte[] test_image1286;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1287.bmp")]
        public static byte[] test_image1287;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1288.bmp")]
        public static byte[] test_image1288;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1289.bmp")]
        public static byte[] test_image1289;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1290.bmp")]
        public static byte[] test_image1290;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1291.bmp")]
        public static byte[] test_image1291;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1292.bmp")]
        public static byte[] test_image1292;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1293.bmp")]
        public static byte[] test_image1293;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1294.bmp")]
        public static byte[] test_image1294;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1295.bmp")]
        public static byte[] test_image1295;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1296.bmp")]
        public static byte[] test_image1296;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1297.bmp")]
        public static byte[] test_image1297;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1298.bmp")]
        public static byte[] test_image1298;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1299.bmp")]
        public static byte[] test_image1299;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1300.bmp")]
        public static byte[] test_image1300;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1301.bmp")]
        public static byte[] test_image1301;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1302.bmp")]
        public static byte[] test_image1302;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1303.bmp")]
        public static byte[] test_image1303;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1304.bmp")]
        public static byte[] test_image1304;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1305.bmp")]
        public static byte[] test_image1305;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1306.bmp")]
        public static byte[] test_image1306;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1307.bmp")]
        public static byte[] test_image1307;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1308.bmp")]
        public static byte[] test_image1308;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1309.bmp")]
        public static byte[] test_image1309;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1310.bmp")]
        public static byte[] test_image1310;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1311.bmp")]
        public static byte[] test_image1311;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1312.bmp")]
        public static byte[] test_image1312;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1313.bmp")]
        public static byte[] test_image1313;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1314.bmp")]
        public static byte[] test_image1314;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1315.bmp")]
        public static byte[] test_image1315;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1316.bmp")]
        public static byte[] test_image1316;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1317.bmp")]
        public static byte[] test_image1317;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1318.bmp")]
        public static byte[] test_image1318;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1319.bmp")]
        public static byte[] test_image1319;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1320.bmp")]
        public static byte[] test_image1320;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1321.bmp")]
        public static byte[] test_image1321;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1322.bmp")]
        public static byte[] test_image1322;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1323.bmp")]
        public static byte[] test_image1323;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1324.bmp")]
        public static byte[] test_image1324;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1325.bmp")]
        public static byte[] test_image1325;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1326.bmp")]
        public static byte[] test_image1326;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1327.bmp")]
        public static byte[] test_image1327;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1328.bmp")]
        public static byte[] test_image1328;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1329.bmp")]
        public static byte[] test_image1329;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1330.bmp")]
        public static byte[] test_image1330;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1331.bmp")]
        public static byte[] test_image1331;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1332.bmp")]
        public static byte[] test_image1332;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1333.bmp")]
        public static byte[] test_image1333;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1334.bmp")]
        public static byte[] test_image1334;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1335.bmp")]
        public static byte[] test_image1335;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1336.bmp")]
        public static byte[] test_image1336;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1337.bmp")]
        public static byte[] test_image1337;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1338.bmp")]
        public static byte[] test_image1338;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1339.bmp")]
        public static byte[] test_image1339;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1340.bmp")]
        public static byte[] test_image1340;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1341.bmp")]
        public static byte[] test_image1341;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1342.bmp")]
        public static byte[] test_image1342;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1343.bmp")]
        public static byte[] test_image1343;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1344.bmp")]
        public static byte[] test_image1344;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1345.bmp")]
        public static byte[] test_image1345;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1346.bmp")]
        public static byte[] test_image1346;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1347.bmp")]
        public static byte[] test_image1347;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1348.bmp")]
        public static byte[] test_image1348;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1349.bmp")]
        public static byte[] test_image1349;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1350.bmp")]
        public static byte[] test_image1350;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1351.bmp")]
        public static byte[] test_image1351;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1352.bmp")]
        public static byte[] test_image1352;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1353.bmp")]
        public static byte[] test_image1353;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1354.bmp")]
        public static byte[] test_image1354;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1355.bmp")]
        public static byte[] test_image1355;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1356.bmp")]
        public static byte[] test_image1356;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1357.bmp")]
        public static byte[] test_image1357;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1358.bmp")]
        public static byte[] test_image1358;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1359.bmp")]
        public static byte[] test_image1359;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1360.bmp")]
        public static byte[] test_image1360;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1361.bmp")]
        public static byte[] test_image1361;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1362.bmp")]
        public static byte[] test_image1362;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1363.bmp")]
        public static byte[] test_image1363;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1364.bmp")]
        public static byte[] test_image1364;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1365.bmp")]
        public static byte[] test_image1365;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1366.bmp")]
        public static byte[] test_image1366;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1367.bmp")]
        public static byte[] test_image1367;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1368.bmp")]
        public static byte[] test_image1368;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1369.bmp")]
        public static byte[] test_image1369;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1370.bmp")]
        public static byte[] test_image1370;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1371.bmp")]
        public static byte[] test_image1371;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1372.bmp")]
        public static byte[] test_image1372;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1373.bmp")]
        public static byte[] test_image1373;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1374.bmp")]
        public static byte[] test_image1374;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1375.bmp")]
        public static byte[] test_image1375;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1376.bmp")]
        public static byte[] test_image1376;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_1377.bmp")]
        public static byte[] test_image1377;


        public static Bitmap image_bitmap = new Bitmap(192, 144, ColorDepth.ColorDepth32);//background

        List<byte[]> images= new List<byte[]>();

        public static Canvas canvas;

        public badApple() //constructor
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);

            loadImages();
        }


        private void loadImages()
        {
            images.Add(test_image1);
            images.Add(test_image2);
            images.Add(test_image3);
            images.Add(test_image4);
            images.Add(test_image5);
            images.Add(test_image6);
            images.Add(test_image7);
            images.Add(test_image8);
            images.Add(test_image9);
            images.Add(test_image10);
            images.Add(test_image11);
            images.Add(test_image12);
            images.Add(test_image13);
            images.Add(test_image14);
            images.Add(test_image15);
            images.Add(test_image16);
            images.Add(test_image17);
            images.Add(test_image18);
            images.Add(test_image19);
            images.Add(test_image20);
            images.Add(test_image21);
            images.Add(test_image22);
            images.Add(test_image23);
            images.Add(test_image24);
            images.Add(test_image25);
            images.Add(test_image26);
            images.Add(test_image27);
            images.Add(test_image28);
            images.Add(test_image29);
            images.Add(test_image30);
            images.Add(test_image31);
            images.Add(test_image32);
            images.Add(test_image33);
            images.Add(test_image34);
            images.Add(test_image35);
            images.Add(test_image36);
            images.Add(test_image37);
            images.Add(test_image38);
            images.Add(test_image39);
            images.Add(test_image40);
            images.Add(test_image41);
            images.Add(test_image42);
            images.Add(test_image43);
            images.Add(test_image44);
            images.Add(test_image45);
            images.Add(test_image46);
            images.Add(test_image47);
            images.Add(test_image48);
            images.Add(test_image49);
            images.Add(test_image50);
            images.Add(test_image51);
            images.Add(test_image52);
            images.Add(test_image53);
            images.Add(test_image54);
            images.Add(test_image55);
            images.Add(test_image56);
            images.Add(test_image57);
            images.Add(test_image58);
            images.Add(test_image59);
            images.Add(test_image60);
            images.Add(test_image61);
            images.Add(test_image62);
            images.Add(test_image63);
            images.Add(test_image64);
            images.Add(test_image65);
            images.Add(test_image66);
            images.Add(test_image67);
            images.Add(test_image68);
            images.Add(test_image69);
            images.Add(test_image70);
            images.Add(test_image71);
            images.Add(test_image72);
            images.Add(test_image73);
            images.Add(test_image74);
            images.Add(test_image75);
            images.Add(test_image76);
            images.Add(test_image77);
            images.Add(test_image78);
            images.Add(test_image79);
            images.Add(test_image80);
            images.Add(test_image81);
            images.Add(test_image82);
            images.Add(test_image83);
            images.Add(test_image84);
            images.Add(test_image85);
            images.Add(test_image86);
            images.Add(test_image87);
            images.Add(test_image88);
            images.Add(test_image89);
            images.Add(test_image90);
            images.Add(test_image91);
            images.Add(test_image92);
            images.Add(test_image93);
            images.Add(test_image94);
            images.Add(test_image95);
            images.Add(test_image96);
            images.Add(test_image97);
            images.Add(test_image98);
            images.Add(test_image99);
            images.Add(test_image100);
            images.Add(test_image101);
            images.Add(test_image102);
            images.Add(test_image103);
            images.Add(test_image104);
            images.Add(test_image105);
            images.Add(test_image106);
            images.Add(test_image107);
            images.Add(test_image108);
            images.Add(test_image109);
            images.Add(test_image110);
            images.Add(test_image111);
            images.Add(test_image112);
            images.Add(test_image113);
            images.Add(test_image114);
            images.Add(test_image115);
            images.Add(test_image116);
            images.Add(test_image117);
            images.Add(test_image118);
            images.Add(test_image119);
            images.Add(test_image120);
            images.Add(test_image121);
            images.Add(test_image122);
            images.Add(test_image123);
            images.Add(test_image124);
            images.Add(test_image125);
            images.Add(test_image126);
            images.Add(test_image127);
            images.Add(test_image128);
            images.Add(test_image129);
            images.Add(test_image130);
            images.Add(test_image131);
            images.Add(test_image132);
            images.Add(test_image133);
            images.Add(test_image134);
            images.Add(test_image135);
            images.Add(test_image136);
            images.Add(test_image137);
            images.Add(test_image138);
            images.Add(test_image139);
            images.Add(test_image140);
            images.Add(test_image141);
            images.Add(test_image142);
            images.Add(test_image143);
            images.Add(test_image144);
            images.Add(test_image145);
            images.Add(test_image146);
            images.Add(test_image147);
            images.Add(test_image148);
            images.Add(test_image149);
            images.Add(test_image150);
            images.Add(test_image151);
            images.Add(test_image152);
            images.Add(test_image153);
            images.Add(test_image154);
            images.Add(test_image155);
            images.Add(test_image156);
            images.Add(test_image157);
            images.Add(test_image158);
            images.Add(test_image159);
            images.Add(test_image160);
            images.Add(test_image161);
            images.Add(test_image162);
            images.Add(test_image163);
            images.Add(test_image164);
            images.Add(test_image165);
            images.Add(test_image166);
            images.Add(test_image167);
            images.Add(test_image168);
            images.Add(test_image169);
            images.Add(test_image170);
            images.Add(test_image171);
            images.Add(test_image172);
            images.Add(test_image173);
            images.Add(test_image174);
            images.Add(test_image175);
            images.Add(test_image176);
            images.Add(test_image177);
            images.Add(test_image178);
            images.Add(test_image179);
            images.Add(test_image180);
            images.Add(test_image181);
            images.Add(test_image182);
            images.Add(test_image183);
            images.Add(test_image184);
            images.Add(test_image185);
            images.Add(test_image186);
            images.Add(test_image187);
            images.Add(test_image188);
            images.Add(test_image189);
            images.Add(test_image190);
            images.Add(test_image191);
            images.Add(test_image192);
            images.Add(test_image193);
            images.Add(test_image194);
            images.Add(test_image195);
            images.Add(test_image196);
            images.Add(test_image197);
            images.Add(test_image198);
            images.Add(test_image199);
            images.Add(test_image200);
            images.Add(test_image201);
            images.Add(test_image202);
            images.Add(test_image203);
            images.Add(test_image204);
            images.Add(test_image205);
            images.Add(test_image206);
            images.Add(test_image207);
            images.Add(test_image208);
            images.Add(test_image209);
            images.Add(test_image210);
            images.Add(test_image211);
            images.Add(test_image212);
            images.Add(test_image213);
            images.Add(test_image214);
            images.Add(test_image215);
            images.Add(test_image216);
            images.Add(test_image217);
            images.Add(test_image218);
            images.Add(test_image219);
            images.Add(test_image220);
            images.Add(test_image221);
            images.Add(test_image222);
            images.Add(test_image223);
            images.Add(test_image224);
            images.Add(test_image225);
            images.Add(test_image226);
            images.Add(test_image227);
            images.Add(test_image228);
            images.Add(test_image229);
            images.Add(test_image230);
            images.Add(test_image231);
            images.Add(test_image232);
            images.Add(test_image233);
            images.Add(test_image234);
            images.Add(test_image235);
            images.Add(test_image236);
            images.Add(test_image237);
            images.Add(test_image238);
            images.Add(test_image239);
            images.Add(test_image240);
            images.Add(test_image241);
            images.Add(test_image242);
            images.Add(test_image243);
            images.Add(test_image244);
            images.Add(test_image245);
            images.Add(test_image246);
            images.Add(test_image247);
            images.Add(test_image248);
            images.Add(test_image249);
            images.Add(test_image250);
            images.Add(test_image251);
            images.Add(test_image252);
            images.Add(test_image253);
            images.Add(test_image254);
            images.Add(test_image255);
            images.Add(test_image256);
            images.Add(test_image257);
            images.Add(test_image258);
            images.Add(test_image259);
            images.Add(test_image260);
            images.Add(test_image261);
            images.Add(test_image262);
            images.Add(test_image263);
            images.Add(test_image264);
            images.Add(test_image265);
            images.Add(test_image266);
            images.Add(test_image267);
            images.Add(test_image268);
            images.Add(test_image269);
            images.Add(test_image270);
            images.Add(test_image271);
            images.Add(test_image272);
            images.Add(test_image273);
            images.Add(test_image274);
            images.Add(test_image275);
            images.Add(test_image276);
            images.Add(test_image277);
            images.Add(test_image278);
            images.Add(test_image279);
            images.Add(test_image280);
            images.Add(test_image281);
            images.Add(test_image282);
            images.Add(test_image283);
            images.Add(test_image284);
            images.Add(test_image285);
            images.Add(test_image286);
            images.Add(test_image287);
            images.Add(test_image288);
            images.Add(test_image289);
            images.Add(test_image290);
            images.Add(test_image291);
            images.Add(test_image292);
            images.Add(test_image293);
            images.Add(test_image294);
            images.Add(test_image295);
            images.Add(test_image296);
            images.Add(test_image297);
            images.Add(test_image298);
            images.Add(test_image299);
            images.Add(test_image300);
            images.Add(test_image301);
            images.Add(test_image302);
            images.Add(test_image303);
            images.Add(test_image304);
            images.Add(test_image305);
            images.Add(test_image306);
            images.Add(test_image307);
            images.Add(test_image308);
            images.Add(test_image309);
            images.Add(test_image310);
            images.Add(test_image311);
            images.Add(test_image312);
            images.Add(test_image313);
            images.Add(test_image314);
            images.Add(test_image315);
            images.Add(test_image316);
            images.Add(test_image317);
            images.Add(test_image318);
            images.Add(test_image319);
            images.Add(test_image320);
            images.Add(test_image321);
            images.Add(test_image322);
            images.Add(test_image323);
            images.Add(test_image324);
            images.Add(test_image325);
            images.Add(test_image326);
            images.Add(test_image327);
            images.Add(test_image328);
            images.Add(test_image329);
            images.Add(test_image330);
            images.Add(test_image331);
            images.Add(test_image332);
            images.Add(test_image333);
            images.Add(test_image334);
            images.Add(test_image335);
            images.Add(test_image336);
            images.Add(test_image337);
            images.Add(test_image338);
            images.Add(test_image339);
            images.Add(test_image340);
            images.Add(test_image341);
            images.Add(test_image342);
            images.Add(test_image343);
            images.Add(test_image344);
            images.Add(test_image345);
            images.Add(test_image346);
            images.Add(test_image347);
            images.Add(test_image348);
            images.Add(test_image349);
            images.Add(test_image350);
            images.Add(test_image351);
            images.Add(test_image352);
            images.Add(test_image353);
            images.Add(test_image354);
            images.Add(test_image355);
            images.Add(test_image356);
            images.Add(test_image357);
            images.Add(test_image358);
            images.Add(test_image359);
            images.Add(test_image360);
            images.Add(test_image361);
            images.Add(test_image362);
            images.Add(test_image363);
            images.Add(test_image364);
            images.Add(test_image365);
            images.Add(test_image366);
            images.Add(test_image367);
            images.Add(test_image368);
            images.Add(test_image369);
            images.Add(test_image370);
            images.Add(test_image371);
            images.Add(test_image372);
            images.Add(test_image373);
            images.Add(test_image374);
            images.Add(test_image375);
            images.Add(test_image376);
            images.Add(test_image377);
            images.Add(test_image378);
            images.Add(test_image379);
            images.Add(test_image380);
            images.Add(test_image381);
            images.Add(test_image382);
            images.Add(test_image383);
            images.Add(test_image384);
            images.Add(test_image385);
            images.Add(test_image386);
            images.Add(test_image387);
            images.Add(test_image388);
            images.Add(test_image389);
            images.Add(test_image390);
            images.Add(test_image391);
            images.Add(test_image392);
            images.Add(test_image393);
            images.Add(test_image394);
            images.Add(test_image395);
            images.Add(test_image396);
            images.Add(test_image397);
            images.Add(test_image398);
            images.Add(test_image399);
            images.Add(test_image400);
            images.Add(test_image401);
            images.Add(test_image402);
            images.Add(test_image403);
            images.Add(test_image404);
            images.Add(test_image405);
            images.Add(test_image406);
            images.Add(test_image407);
            images.Add(test_image408);
            images.Add(test_image409);
            images.Add(test_image410);
            images.Add(test_image411);
            images.Add(test_image412);
            images.Add(test_image413);
            images.Add(test_image414);
            images.Add(test_image415);
            images.Add(test_image416);
            images.Add(test_image417);
            images.Add(test_image418);
            images.Add(test_image419);
            images.Add(test_image420);
            images.Add(test_image421);
            images.Add(test_image422);
            images.Add(test_image423);
            images.Add(test_image424);
            images.Add(test_image425);
            images.Add(test_image426);
            images.Add(test_image427);
            images.Add(test_image428);
            images.Add(test_image429);
            images.Add(test_image430);
            images.Add(test_image431);
            images.Add(test_image432);
            images.Add(test_image433);
            images.Add(test_image434);
            images.Add(test_image435);
            images.Add(test_image436);
            images.Add(test_image437);
            images.Add(test_image438);
            images.Add(test_image439);
            images.Add(test_image440);
            images.Add(test_image441);
            images.Add(test_image442);
            images.Add(test_image443);
            images.Add(test_image444);
            images.Add(test_image445);
            images.Add(test_image446);
            images.Add(test_image447);
            images.Add(test_image448);
            images.Add(test_image449);
            images.Add(test_image450);
            images.Add(test_image451);
            images.Add(test_image452);
            images.Add(test_image453);
            images.Add(test_image454);
            images.Add(test_image455);
            images.Add(test_image456);
            images.Add(test_image457);
            images.Add(test_image458);
            images.Add(test_image459);
            images.Add(test_image460);
            images.Add(test_image461);
            images.Add(test_image462);
            images.Add(test_image463);
            images.Add(test_image464);
            images.Add(test_image465);
            images.Add(test_image466);
            images.Add(test_image467);
            images.Add(test_image468);
            images.Add(test_image469);
            images.Add(test_image470);
            images.Add(test_image471);
            images.Add(test_image472);
            images.Add(test_image473);
            images.Add(test_image474);
            images.Add(test_image475);
            images.Add(test_image476);
            images.Add(test_image477);
            images.Add(test_image478);
            images.Add(test_image479);
            images.Add(test_image480);
            images.Add(test_image481);
            images.Add(test_image482);
            images.Add(test_image483);
            images.Add(test_image484);
            images.Add(test_image485);
            images.Add(test_image486);
            images.Add(test_image487);
            images.Add(test_image488);
            images.Add(test_image489);
            images.Add(test_image490);
            images.Add(test_image491);
            images.Add(test_image492);
            images.Add(test_image493);
            images.Add(test_image494);
            images.Add(test_image495);
            images.Add(test_image496);
            images.Add(test_image497);
            images.Add(test_image498);
            images.Add(test_image499);
            images.Add(test_image500);
            images.Add(test_image501);
            images.Add(test_image502);
            images.Add(test_image503);
            images.Add(test_image504);
            images.Add(test_image505);
            images.Add(test_image506);
            images.Add(test_image507);
            images.Add(test_image508);
            images.Add(test_image509);
            images.Add(test_image510);
            images.Add(test_image511);
            images.Add(test_image512);
            images.Add(test_image513);
            images.Add(test_image514);
            images.Add(test_image515);
            images.Add(test_image516);
            images.Add(test_image517);
            images.Add(test_image518);
            images.Add(test_image519);
            images.Add(test_image520);
            images.Add(test_image521);
            images.Add(test_image522);
            images.Add(test_image523);
            images.Add(test_image524);
            images.Add(test_image525);
            images.Add(test_image526);
            images.Add(test_image527);
            images.Add(test_image528);
            images.Add(test_image529);
            images.Add(test_image530);
            images.Add(test_image531);
            images.Add(test_image532);
            images.Add(test_image533);
            images.Add(test_image534);
            images.Add(test_image535);
            images.Add(test_image536);
            images.Add(test_image537);
            images.Add(test_image538);
            images.Add(test_image539);
            images.Add(test_image540);
            images.Add(test_image541);
            images.Add(test_image542);
            images.Add(test_image543);
            images.Add(test_image544);
            images.Add(test_image545);
            images.Add(test_image546);
            images.Add(test_image547);
            images.Add(test_image548);
            images.Add(test_image549);
            images.Add(test_image550);
            images.Add(test_image551);
            images.Add(test_image552);
            images.Add(test_image553);
            images.Add(test_image554);
            images.Add(test_image555);
            images.Add(test_image556);
            images.Add(test_image557);
            images.Add(test_image558);
            images.Add(test_image559);
            images.Add(test_image560);
            images.Add(test_image561);
            images.Add(test_image562);
            images.Add(test_image563);
            images.Add(test_image564);
            images.Add(test_image565);
            images.Add(test_image566);
            images.Add(test_image567);
            images.Add(test_image568);
            images.Add(test_image569);
            images.Add(test_image570);
            images.Add(test_image571);
            images.Add(test_image572);
            images.Add(test_image573);
            images.Add(test_image574);
            images.Add(test_image575);
            images.Add(test_image576);
            images.Add(test_image577);
            images.Add(test_image578);
            images.Add(test_image579);
            images.Add(test_image580);
            images.Add(test_image581);
            images.Add(test_image582);
            images.Add(test_image583);
            images.Add(test_image584);
            images.Add(test_image585);
            images.Add(test_image586);
            images.Add(test_image587);
            images.Add(test_image588);
            images.Add(test_image589);
            images.Add(test_image590);
            images.Add(test_image591);
            images.Add(test_image592);
            images.Add(test_image593);
            images.Add(test_image594);
            images.Add(test_image595);
            images.Add(test_image596);
            images.Add(test_image597);
            images.Add(test_image598);
            images.Add(test_image599);
            images.Add(test_image600);
            images.Add(test_image601);
            images.Add(test_image602);
            images.Add(test_image603);
            images.Add(test_image604);
            images.Add(test_image605);
            images.Add(test_image606);
            images.Add(test_image607);
            images.Add(test_image608);
            images.Add(test_image609);
            images.Add(test_image610);
            images.Add(test_image611);
            images.Add(test_image612);
            images.Add(test_image613);
            images.Add(test_image614);
            images.Add(test_image615);
            images.Add(test_image616);
            images.Add(test_image617);
            images.Add(test_image618);
            images.Add(test_image619);
            images.Add(test_image620);
            images.Add(test_image621);
            images.Add(test_image622);
            images.Add(test_image623);
            images.Add(test_image624);
            images.Add(test_image625);
            images.Add(test_image626);
            images.Add(test_image627);
            images.Add(test_image628);
            images.Add(test_image629);
            images.Add(test_image630);
            images.Add(test_image631);
            images.Add(test_image632);
            images.Add(test_image633);
            images.Add(test_image634);
            images.Add(test_image635);
            images.Add(test_image636);
            images.Add(test_image637);
            images.Add(test_image638);
            images.Add(test_image639);
            images.Add(test_image640);
            images.Add(test_image641);
            images.Add(test_image642);
            images.Add(test_image643);
            images.Add(test_image644);
            images.Add(test_image645);
            images.Add(test_image646);
            images.Add(test_image647);
            images.Add(test_image648);
            images.Add(test_image649);
            images.Add(test_image650);
            images.Add(test_image651);
            images.Add(test_image652);
            images.Add(test_image653);
            images.Add(test_image654);
            images.Add(test_image655);
            images.Add(test_image656);
            images.Add(test_image657);
            images.Add(test_image658);
            images.Add(test_image659);
            images.Add(test_image660);
            images.Add(test_image661);
            images.Add(test_image662);
            images.Add(test_image663);
            images.Add(test_image664);
            images.Add(test_image665);
            images.Add(test_image666);
            images.Add(test_image667);
            images.Add(test_image668);
            images.Add(test_image669);
            images.Add(test_image670);
            images.Add(test_image671);
            images.Add(test_image672);
            images.Add(test_image673);
            images.Add(test_image674);
            images.Add(test_image675);
            images.Add(test_image676);
            images.Add(test_image677);
            images.Add(test_image678);
            images.Add(test_image679);
            images.Add(test_image680);
            images.Add(test_image681);
            images.Add(test_image682);
            images.Add(test_image683);
            images.Add(test_image684);
            images.Add(test_image685);
            images.Add(test_image686);
            images.Add(test_image687);
            images.Add(test_image688);
            images.Add(test_image689);
            images.Add(test_image690);
            images.Add(test_image691);
            images.Add(test_image692);
            images.Add(test_image693);
            images.Add(test_image694);
            images.Add(test_image695);
            images.Add(test_image696);
            images.Add(test_image697);
            images.Add(test_image698);
            images.Add(test_image699);
            images.Add(test_image700);
            images.Add(test_image701);
            images.Add(test_image702);
            images.Add(test_image703);
            images.Add(test_image704);
            images.Add(test_image705);
            images.Add(test_image706);
            images.Add(test_image707);
            images.Add(test_image708);
            images.Add(test_image709);
            images.Add(test_image710);
            images.Add(test_image711);
            images.Add(test_image712);
            images.Add(test_image713);
            images.Add(test_image714);
            images.Add(test_image715);
            images.Add(test_image716);
            images.Add(test_image717);
            images.Add(test_image718);
            images.Add(test_image719);
            images.Add(test_image720);
            images.Add(test_image721);
            images.Add(test_image722);
            images.Add(test_image723);
            images.Add(test_image724);
            images.Add(test_image725);
            images.Add(test_image726);
            images.Add(test_image727);
            images.Add(test_image728);
            images.Add(test_image729);
            images.Add(test_image730);
            images.Add(test_image731);
            images.Add(test_image732);
            images.Add(test_image733);
            images.Add(test_image734);
            images.Add(test_image735);
            images.Add(test_image736);
            images.Add(test_image737);
            images.Add(test_image738);
            images.Add(test_image739);
            images.Add(test_image740);
            images.Add(test_image741);
            images.Add(test_image742);
            images.Add(test_image743);
            images.Add(test_image744);
            images.Add(test_image745);
            images.Add(test_image746);
            images.Add(test_image747);
            images.Add(test_image748);
            images.Add(test_image749);
            images.Add(test_image750);
            images.Add(test_image751);
            images.Add(test_image752);
            images.Add(test_image753);
            images.Add(test_image754);
            images.Add(test_image755);
            images.Add(test_image756);
            images.Add(test_image757);
            images.Add(test_image758);
            images.Add(test_image759);
            images.Add(test_image760);
            images.Add(test_image761);
            images.Add(test_image762);
            images.Add(test_image763);
            images.Add(test_image764);
            images.Add(test_image765);
            images.Add(test_image766);
            images.Add(test_image767);
            images.Add(test_image768);
            images.Add(test_image769);
            images.Add(test_image770);
            images.Add(test_image771);
            images.Add(test_image772);
            images.Add(test_image773);
            images.Add(test_image774);
            images.Add(test_image775);
            images.Add(test_image776);
            images.Add(test_image777);
            images.Add(test_image778);
            images.Add(test_image779);
            images.Add(test_image780);
            images.Add(test_image781);
            images.Add(test_image782);
            images.Add(test_image783);
            images.Add(test_image784);
            images.Add(test_image785);
            images.Add(test_image786);
            images.Add(test_image787);
            images.Add(test_image788);
            images.Add(test_image789);
            images.Add(test_image790);
            images.Add(test_image791);
            images.Add(test_image792);
            images.Add(test_image793);
            images.Add(test_image794);
            images.Add(test_image795);
            images.Add(test_image796);
            images.Add(test_image797);
            images.Add(test_image798);
            images.Add(test_image799);
            images.Add(test_image800);
            images.Add(test_image801);
            images.Add(test_image802);
            images.Add(test_image803);
            images.Add(test_image804);
            images.Add(test_image805);
            images.Add(test_image806);
            images.Add(test_image807);
            images.Add(test_image808);
            images.Add(test_image809);
            images.Add(test_image810);
            images.Add(test_image811);
            images.Add(test_image812);
            images.Add(test_image813);
            images.Add(test_image814);
            images.Add(test_image815);
            images.Add(test_image816);
            images.Add(test_image817);
            images.Add(test_image818);
            images.Add(test_image819);
            images.Add(test_image820);
            images.Add(test_image821);
            images.Add(test_image822);
            images.Add(test_image823);
            images.Add(test_image824);
            images.Add(test_image825);
            images.Add(test_image826);
            images.Add(test_image827);
            images.Add(test_image828);
            images.Add(test_image829);
            images.Add(test_image830);
            images.Add(test_image831);
            images.Add(test_image832);
            images.Add(test_image833);
            images.Add(test_image834);
            images.Add(test_image835);
            images.Add(test_image836);
            images.Add(test_image837);
            images.Add(test_image838);
            images.Add(test_image839);
            images.Add(test_image840);
            images.Add(test_image841);
            images.Add(test_image842);
            images.Add(test_image843);
            images.Add(test_image844);
            images.Add(test_image845);
            images.Add(test_image846);
            images.Add(test_image847);
            images.Add(test_image848);
            images.Add(test_image849);
            images.Add(test_image850);
            images.Add(test_image851);
            images.Add(test_image852);
            images.Add(test_image853);
            images.Add(test_image854);
            images.Add(test_image855);
            images.Add(test_image856);
            images.Add(test_image857);
            images.Add(test_image858);
            images.Add(test_image859);
            images.Add(test_image860);
            images.Add(test_image861);
            images.Add(test_image862);
            images.Add(test_image863);
            images.Add(test_image864);
            images.Add(test_image865);
            images.Add(test_image866);
            images.Add(test_image867);
            images.Add(test_image868);
            images.Add(test_image869);
            images.Add(test_image870);
            images.Add(test_image871);
            images.Add(test_image872);
            images.Add(test_image873);
            images.Add(test_image874);
            images.Add(test_image875);
            images.Add(test_image876);
            images.Add(test_image877);
            images.Add(test_image878);
            images.Add(test_image879);
            images.Add(test_image880);
            images.Add(test_image881);
            images.Add(test_image882);
            images.Add(test_image883);
            images.Add(test_image884);
            images.Add(test_image885);
            images.Add(test_image886);
            images.Add(test_image887);
            images.Add(test_image888);
            images.Add(test_image889);
            images.Add(test_image890);
            images.Add(test_image891);
            images.Add(test_image892);
            images.Add(test_image893);
            images.Add(test_image894);
            images.Add(test_image895);
            images.Add(test_image896);
            images.Add(test_image897);
            images.Add(test_image898);
            images.Add(test_image899);
            images.Add(test_image900);
            images.Add(test_image901);
            images.Add(test_image902);
            images.Add(test_image903);
            images.Add(test_image904);
            images.Add(test_image905);
            images.Add(test_image906);
            images.Add(test_image907);
            images.Add(test_image908);
            images.Add(test_image909);
            images.Add(test_image910);
            images.Add(test_image911);
            images.Add(test_image912);
            images.Add(test_image913);
            images.Add(test_image914);
            images.Add(test_image915);
            images.Add(test_image916);
            images.Add(test_image917);
            images.Add(test_image918);
            images.Add(test_image919);
            images.Add(test_image920);
            images.Add(test_image921);
            images.Add(test_image922);
            images.Add(test_image923);
            images.Add(test_image924);
            images.Add(test_image925);
            images.Add(test_image926);
            images.Add(test_image927);
            images.Add(test_image928);
            images.Add(test_image929);
            images.Add(test_image930);
            images.Add(test_image931);
            images.Add(test_image932);
            images.Add(test_image933);
            images.Add(test_image934);
            images.Add(test_image935);
            images.Add(test_image936);
            images.Add(test_image937);
            images.Add(test_image938);
            images.Add(test_image939);
            images.Add(test_image940);
            images.Add(test_image941);
            images.Add(test_image942);
            images.Add(test_image943);
            images.Add(test_image944);
            images.Add(test_image945);
            images.Add(test_image946);
            images.Add(test_image947);
            images.Add(test_image948);
            images.Add(test_image949);
            images.Add(test_image950);
            images.Add(test_image951);
            images.Add(test_image952);
            images.Add(test_image953);
            images.Add(test_image954);
            images.Add(test_image955);
            images.Add(test_image956);
            images.Add(test_image957);
            images.Add(test_image958);
            images.Add(test_image959);
            images.Add(test_image960);
            images.Add(test_image961);
            images.Add(test_image962);
            images.Add(test_image963);
            images.Add(test_image964);
            images.Add(test_image965);
            images.Add(test_image966);
            images.Add(test_image967);
            images.Add(test_image968);
            images.Add(test_image969);
            images.Add(test_image970);
            images.Add(test_image971);
            images.Add(test_image972);
            images.Add(test_image973);
            images.Add(test_image974);
            images.Add(test_image975);
            images.Add(test_image976);
            images.Add(test_image977);
            images.Add(test_image978);
            images.Add(test_image979);
            images.Add(test_image980);
            images.Add(test_image981);
            images.Add(test_image982);
            images.Add(test_image983);
            images.Add(test_image984);
            images.Add(test_image985);
            images.Add(test_image986);
            images.Add(test_image987);
            images.Add(test_image988);
            images.Add(test_image989);
            images.Add(test_image990);
            images.Add(test_image991);
            images.Add(test_image992);
            images.Add(test_image993);
            images.Add(test_image994);
            images.Add(test_image995);
            images.Add(test_image996);
            images.Add(test_image997);
            images.Add(test_image998);
            images.Add(test_image999);
            images.Add(test_image1000);
            images.Add(test_image1001);
            images.Add(test_image1002);
            images.Add(test_image1003);
            images.Add(test_image1004);
            images.Add(test_image1005);
            images.Add(test_image1006);
            images.Add(test_image1007);
            images.Add(test_image1008);
            images.Add(test_image1009);
            images.Add(test_image1010);
            images.Add(test_image1011);
            images.Add(test_image1012);
            images.Add(test_image1013);
            images.Add(test_image1014);
            images.Add(test_image1015);
            images.Add(test_image1016);
            images.Add(test_image1017);
            images.Add(test_image1018);
            images.Add(test_image1019);
            images.Add(test_image1020);
            images.Add(test_image1021);
            images.Add(test_image1022);
            images.Add(test_image1023);
            images.Add(test_image1024);
            images.Add(test_image1025);
            images.Add(test_image1026);
            images.Add(test_image1027);
            images.Add(test_image1028);
            images.Add(test_image1029);
            images.Add(test_image1030);
            images.Add(test_image1031);
            images.Add(test_image1032);
            images.Add(test_image1033);
            images.Add(test_image1034);
            images.Add(test_image1035);
            images.Add(test_image1036);
            images.Add(test_image1037);
            images.Add(test_image1038);
            images.Add(test_image1039);
            images.Add(test_image1040);
            images.Add(test_image1041);
            images.Add(test_image1042);
            images.Add(test_image1043);
            images.Add(test_image1044);
            images.Add(test_image1045);
            images.Add(test_image1046);
            images.Add(test_image1047);
            images.Add(test_image1048);
            images.Add(test_image1049);
            images.Add(test_image1050);
            images.Add(test_image1051);
            images.Add(test_image1052);
            images.Add(test_image1053);
            images.Add(test_image1054);
            images.Add(test_image1055);
            images.Add(test_image1056);
            images.Add(test_image1057);
            images.Add(test_image1058);
            images.Add(test_image1059);
            images.Add(test_image1060);
            images.Add(test_image1061);
            images.Add(test_image1062);
            images.Add(test_image1063);
            images.Add(test_image1064);
            images.Add(test_image1065);
            images.Add(test_image1066);
            images.Add(test_image1067);
            images.Add(test_image1068);
            images.Add(test_image1069);
            images.Add(test_image1070);
            images.Add(test_image1071);
            images.Add(test_image1072);
            images.Add(test_image1073);
            images.Add(test_image1074);
            images.Add(test_image1075);
            images.Add(test_image1076);
            images.Add(test_image1077);
            images.Add(test_image1078);
            images.Add(test_image1079);
            images.Add(test_image1080);
            images.Add(test_image1081);
            images.Add(test_image1082);
            images.Add(test_image1083);
            images.Add(test_image1084);
            images.Add(test_image1085);
            images.Add(test_image1086);
            images.Add(test_image1087);
            images.Add(test_image1088);
            images.Add(test_image1089);
            images.Add(test_image1090);
            images.Add(test_image1091);
            images.Add(test_image1092);
            images.Add(test_image1093);
            images.Add(test_image1094);
            images.Add(test_image1095);
            images.Add(test_image1096);
            images.Add(test_image1097);
            images.Add(test_image1098);
            images.Add(test_image1099);
            images.Add(test_image1100);
            images.Add(test_image1101);
            images.Add(test_image1102);
            images.Add(test_image1103);
            images.Add(test_image1104);
            images.Add(test_image1105);
            images.Add(test_image1106);
            images.Add(test_image1107);
            images.Add(test_image1108);
            images.Add(test_image1109);
            images.Add(test_image1110);
            images.Add(test_image1111);
            images.Add(test_image1112);
            images.Add(test_image1113);
            images.Add(test_image1114);
            images.Add(test_image1115);
            images.Add(test_image1116);
            images.Add(test_image1117);
            images.Add(test_image1118);
            images.Add(test_image1119);
            images.Add(test_image1120);
            images.Add(test_image1121);
            images.Add(test_image1122);
            images.Add(test_image1123);
            images.Add(test_image1124);
            images.Add(test_image1125);
            images.Add(test_image1126);
            images.Add(test_image1127);
            images.Add(test_image1128);
            images.Add(test_image1129);
            images.Add(test_image1130);
            images.Add(test_image1131);
            images.Add(test_image1132);
            images.Add(test_image1133);
            images.Add(test_image1134);
            images.Add(test_image1135);
            images.Add(test_image1136);
            images.Add(test_image1137);
            images.Add(test_image1138);
            images.Add(test_image1139);
            images.Add(test_image1140);
            images.Add(test_image1141);
            images.Add(test_image1142);
            images.Add(test_image1143);
            images.Add(test_image1144);
            images.Add(test_image1145);
            images.Add(test_image1146);
            images.Add(test_image1147);
            images.Add(test_image1148);
            images.Add(test_image1149);
            images.Add(test_image1150);
            images.Add(test_image1151);
            images.Add(test_image1152);
            images.Add(test_image1153);
            images.Add(test_image1154);
            images.Add(test_image1155);
            images.Add(test_image1156);
            images.Add(test_image1157);
            images.Add(test_image1158);
            images.Add(test_image1159);
            images.Add(test_image1160);
            images.Add(test_image1161);
            images.Add(test_image1162);
            images.Add(test_image1163);
            images.Add(test_image1164);
            images.Add(test_image1165);
            images.Add(test_image1166);
            images.Add(test_image1167);
            images.Add(test_image1168);
            images.Add(test_image1169);
            images.Add(test_image1170);
            images.Add(test_image1171);
            images.Add(test_image1172);
            images.Add(test_image1173);
            images.Add(test_image1174);
            images.Add(test_image1175);
            images.Add(test_image1176);
            images.Add(test_image1177);
            images.Add(test_image1178);
            images.Add(test_image1179);
            images.Add(test_image1180);
            images.Add(test_image1181);
            images.Add(test_image1182);
            images.Add(test_image1183);
            images.Add(test_image1184);
            images.Add(test_image1185);
            images.Add(test_image1186);
            images.Add(test_image1187);
            images.Add(test_image1188);
            images.Add(test_image1189);
            images.Add(test_image1190);
            images.Add(test_image1191);
            images.Add(test_image1192);
            images.Add(test_image1193);
            images.Add(test_image1194);
            images.Add(test_image1195);
            images.Add(test_image1196);
            images.Add(test_image1197);
            images.Add(test_image1198);
            images.Add(test_image1199);
            images.Add(test_image1200);
            images.Add(test_image1201);
            images.Add(test_image1202);
            images.Add(test_image1203);
            images.Add(test_image1204);
            images.Add(test_image1205);
            images.Add(test_image1206);
            images.Add(test_image1207);
            images.Add(test_image1208);
            images.Add(test_image1209);
            images.Add(test_image1210);
            images.Add(test_image1211);
            images.Add(test_image1212);
            images.Add(test_image1213);
            images.Add(test_image1214);
            images.Add(test_image1215);
            images.Add(test_image1216);
            images.Add(test_image1217);
            images.Add(test_image1218);
            images.Add(test_image1219);
            images.Add(test_image1220);
            images.Add(test_image1221);
            images.Add(test_image1222);
            images.Add(test_image1223);
            images.Add(test_image1224);
            images.Add(test_image1225);
            images.Add(test_image1226);
            images.Add(test_image1227);
            images.Add(test_image1228);
            images.Add(test_image1229);
            images.Add(test_image1230);
            images.Add(test_image1231);
            images.Add(test_image1232);
            images.Add(test_image1233);
            images.Add(test_image1234);
            images.Add(test_image1235);
            images.Add(test_image1236);
            images.Add(test_image1237);
            images.Add(test_image1238);
            images.Add(test_image1239);
            images.Add(test_image1240);
            images.Add(test_image1241);
            images.Add(test_image1242);
            images.Add(test_image1243);
            images.Add(test_image1244);
            images.Add(test_image1245);
            images.Add(test_image1246);
            images.Add(test_image1247);
            images.Add(test_image1248);
            images.Add(test_image1249);
            images.Add(test_image1250);
            images.Add(test_image1251);
            images.Add(test_image1252);
            images.Add(test_image1253);
            images.Add(test_image1254);
            images.Add(test_image1255);
            images.Add(test_image1256);
            images.Add(test_image1257);
            images.Add(test_image1258);
            images.Add(test_image1259);
            images.Add(test_image1260);
            images.Add(test_image1261);
            images.Add(test_image1262);
            images.Add(test_image1263);
            images.Add(test_image1264);
            images.Add(test_image1265);
            images.Add(test_image1266);
            images.Add(test_image1267);
            images.Add(test_image1268);
            images.Add(test_image1269);
            images.Add(test_image1270);
            images.Add(test_image1271);
            images.Add(test_image1272);
            images.Add(test_image1273);
            images.Add(test_image1274);
            images.Add(test_image1275);
            images.Add(test_image1276);
            images.Add(test_image1277);
            images.Add(test_image1278);
            images.Add(test_image1279);
            images.Add(test_image1280);
            images.Add(test_image1281);
            images.Add(test_image1282);
            images.Add(test_image1283);
            images.Add(test_image1284);
            images.Add(test_image1285);
            images.Add(test_image1286);
            images.Add(test_image1287);
            images.Add(test_image1288);
            images.Add(test_image1289);
            images.Add(test_image1290);
            images.Add(test_image1291);
            images.Add(test_image1292);
            images.Add(test_image1293);
            images.Add(test_image1294);
            images.Add(test_image1295);
            images.Add(test_image1296);
            images.Add(test_image1297);
            images.Add(test_image1298);
            images.Add(test_image1299);
            images.Add(test_image1300);
            images.Add(test_image1301);
            images.Add(test_image1302);
            images.Add(test_image1303);
            images.Add(test_image1304);
            images.Add(test_image1305);
            images.Add(test_image1306);
            images.Add(test_image1307);
            images.Add(test_image1308);
            images.Add(test_image1309);
            images.Add(test_image1310);
            images.Add(test_image1311);
            images.Add(test_image1312);
            images.Add(test_image1313);
            images.Add(test_image1314);
            images.Add(test_image1315);
            images.Add(test_image1316);
            images.Add(test_image1317);
            images.Add(test_image1318);
            images.Add(test_image1319);
            images.Add(test_image1320);
            images.Add(test_image1321);
            images.Add(test_image1322);
            images.Add(test_image1323);
            images.Add(test_image1324);
            images.Add(test_image1325);
            images.Add(test_image1326);
            images.Add(test_image1327);
            images.Add(test_image1328);
            images.Add(test_image1329);
            images.Add(test_image1330);
            images.Add(test_image1331);
            images.Add(test_image1332);
            images.Add(test_image1333);
            images.Add(test_image1334);
            images.Add(test_image1335);
            images.Add(test_image1336);
            images.Add(test_image1337);
            images.Add(test_image1338);
            images.Add(test_image1339);
            images.Add(test_image1340);
            images.Add(test_image1341);
            images.Add(test_image1342);
            images.Add(test_image1343);
            images.Add(test_image1344);
            images.Add(test_image1345);
            images.Add(test_image1346);
            images.Add(test_image1347);
            images.Add(test_image1348);
            images.Add(test_image1349);
            images.Add(test_image1350);
            images.Add(test_image1351);
            images.Add(test_image1352);
            images.Add(test_image1353);
            images.Add(test_image1354);
            images.Add(test_image1355);
            images.Add(test_image1356);
            images.Add(test_image1357);
            images.Add(test_image1358);
            images.Add(test_image1359);
            images.Add(test_image1360);
            images.Add(test_image1361);
            images.Add(test_image1362);
            images.Add(test_image1363);
            images.Add(test_image1364);
            images.Add(test_image1365);
            images.Add(test_image1366);
            images.Add(test_image1367);
            images.Add(test_image1368);
            images.Add(test_image1369);
            images.Add(test_image1370);
            images.Add(test_image1371);
            images.Add(test_image1372);
            images.Add(test_image1373);
            images.Add(test_image1374);
            images.Add(test_image1375);
            images.Add(test_image1376);
            images.Add(test_image1377);
        }
        public void handleAppleInputs()
        {
            foreach (var image in images)
            {
                image_bitmap = new Bitmap(image);
                canvas.DrawImage(image_bitmap, 0, 0);
                canvas.Display();

                Thread.Sleep(200);

                if (KeyboardManager.KeyAvailable)
                {
                    if (KeyboardManager.ReadKey().Key == ConsoleKeyEx.Escape)
                    {
                        ShouldExitApple = true;
                    }
                }
            }
        }
    }




}