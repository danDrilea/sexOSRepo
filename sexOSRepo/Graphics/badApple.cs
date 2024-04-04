using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

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

        public static Bitmap image_bitmap = new Bitmap(192, 144, ColorDepth.ColorDepth32);//background

        List<byte[]> images = new List<byte[]>();

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
        }
        public void handleAppleInputs()
        {
            if (KeyboardManager.KeyAvailable)
            {
                if (KeyboardManager.ReadKey().Key == ConsoleKeyEx.Escape)
                {
                    ShouldExitApple = true;
                    Heap.Collect();
                }
                else if (KeyboardManager.ReadKey().Key == ConsoleKeyEx.Enter)
                {
                    foreach (var image in images)
                    {
                        image_bitmap = new Bitmap(image);
                        canvas.DrawImage(image_bitmap, 0, 0);
                        canvas.Display();

                        Thread.Sleep(100);
                    }
                    Heap.Collect();
                    ShouldExitApple = true;
                }
            }
        }
    }




}