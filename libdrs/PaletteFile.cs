﻿using System;
using System.Drawing;

namespace libdrs
{
	public static class PaletteFile
	{
		public static Color[] HardcodedPalette = new Color[256]
		{
			Color.FromArgb(  0,   0,   0), // 0 - Black
			Color.FromArgb(  0,  74, 161),
			Color.FromArgb(  0,  97, 155),
			Color.FromArgb(  0,  74, 187),
			Color.FromArgb(  0,  84, 176),
			Color.FromArgb(  0,  90, 184),
			Color.FromArgb(  0, 110, 176),
			Color.FromArgb(  0, 110, 187),
			Color.FromArgb(180, 255, 180),
			Color.FromArgb(  0,  98, 210),
			Color.FromArgb(  0,   0,   0), // 10
			Color.FromArgb( 47,  47,  47),
			Color.FromArgb(200, 216, 255),
			Color.FromArgb( 87,  87,  87),
			Color.FromArgb( 37,  16,   6),
			Color.FromArgb( 47,  26,  17),
			Color.FromArgb(  0,   0,  82),
			Color.FromArgb(  0,  21, 130),
			Color.FromArgb( 19,  49, 161),
			Color.FromArgb( 48,  93, 182),
			Color.FromArgb( 74, 121, 208), // 20
			Color.FromArgb(110, 166, 235),
			Color.FromArgb(151, 206, 255),
			Color.FromArgb(205, 250, 255),
			Color.FromArgb( 64,  43,  23),
			Color.FromArgb( 67,  51,  27),
			Color.FromArgb( 70,  32,   6),
			Color.FromArgb( 75,  57,  42),
			Color.FromArgb( 84,  64,  43),
			Color.FromArgb( 87,  69,  37),
			Color.FromArgb( 87,  57,  27), // 30
			Color.FromArgb( 94,  74,  48),
			Color.FromArgb( 65,   0,   0),
			Color.FromArgb(105,  11,   0),
			Color.FromArgb(160,  21,   0),
			Color.FromArgb(230,  11,   0),
			Color.FromArgb(255,   0,   0),
			Color.FromArgb(255, 100, 100),
			Color.FromArgb(255, 160, 160),
			Color.FromArgb(255, 220, 220),
			Color.FromArgb( 97,  77,  67), // 40
			Color.FromArgb(103,  58,  21),
			Color.FromArgb(113,  75,  51),
			Color.FromArgb(113,  75,  13),
			Color.FromArgb(115, 105,  84),
			Color.FromArgb(125,  97,  72),
			Color.FromArgb(125,  74,   0),
			Color.FromArgb(129, 116,  95),
			Color.FromArgb(  0,   0,   0),
			Color.FromArgb(  0,   7,   0),
			Color.FromArgb(  0,  32,   0), // 50
			Color.FromArgb(  0,  59,   0),
			Color.FromArgb(  0,  87,   0),
			Color.FromArgb(  0, 114,   0),
			Color.FromArgb(  0, 141,   0),
			Color.FromArgb(  0, 169,   0),
			Color.FromArgb(134, 126, 118), // 56 - Shadow color
			Color.FromArgb(135,  64,   0),
			Color.FromArgb(136, 108,  79),
			Color.FromArgb(144, 100,  12),
			Color.FromArgb(146, 125, 105), // 60
			Color.FromArgb(153, 106,  55),
			Color.FromArgb(159, 121,  88),
			Color.FromArgb(166,  74,   0),
			Color.FromArgb( 80,  51,  26),
			Color.FromArgb(140,  78,   9),
			Color.FromArgb(191, 123,   0),
			Color.FromArgb(255, 199,   0),
			Color.FromArgb(255, 247,  37),
			Color.FromArgb(255, 255,  97),
			Color.FromArgb(255, 255, 166), // 70
			Color.FromArgb(255, 255, 227),
			Color.FromArgb(167, 135, 102),
			Color.FromArgb(172, 144, 115),
			Color.FromArgb(175, 126,  36),
			Color.FromArgb(175, 151, 128),
			Color.FromArgb(185, 151, 146),
			Color.FromArgb(186, 166, 135),
			Color.FromArgb(187,  84,   0),
			Color.FromArgb(187, 156, 125),
			Color.FromArgb(110,  23,   0), // 80
			Color.FromArgb(150,  36,   0),
			Color.FromArgb(210,  55,   0),
			Color.FromArgb(255,  80,   0),
			Color.FromArgb(255, 130,   1),
			Color.FromArgb(255, 180,  21),
			Color.FromArgb(255, 210,  75),
			Color.FromArgb(255, 235, 160),
			Color.FromArgb(189, 150, 111),
			Color.FromArgb(191, 169, 115),
			Color.FromArgb(195, 174, 156), // 90
			Color.FromArgb(196, 170, 146),
			Color.FromArgb(196, 128,  88),
			Color.FromArgb(196, 166, 135),
			Color.FromArgb(197, 187, 176),
			Color.FromArgb(204, 160,  36),
			Color.FromArgb(  0,  16,  16),
			Color.FromArgb(  0,  37,  41),
			Color.FromArgb(  0,  80,  80),
			Color.FromArgb(  0, 120, 115),
			Color.FromArgb(  0, 172, 150), // 100
			Color.FromArgb( 38, 223, 170),
			Color.FromArgb(109, 252, 191),
			Color.FromArgb(186, 255, 222),
			Color.FromArgb(206, 169, 133),
			Color.FromArgb(207, 105,  12),
			Color.FromArgb(207, 176, 156),
			Color.FromArgb(228, 162,  82),
			Color.FromArgb(215, 186, 155),
			Color.FromArgb(216, 162, 121),
			Color.FromArgb(217, 114,  24), // 110
			Color.FromArgb(223, 234, 255),
			Color.FromArgb( 47,   0,  46),
			Color.FromArgb( 79,   0,  75),
			Color.FromArgb(133,  12, 121),
			Color.FromArgb(170,  47, 155),
			Color.FromArgb(211,  58, 201),
			Color.FromArgb(241, 108, 232),
			Color.FromArgb(255, 169, 255),
			Color.FromArgb(255, 210, 255),
			Color.FromArgb(218, 156, 105), // 120
			Color.FromArgb(222, 177, 136),
			Color.FromArgb(225, 177,  90),
			Color.FromArgb(226, 195, 170),
			Color.FromArgb(232, 180, 120),
			Color.FromArgb(235, 202, 181),
			Color.FromArgb(235, 216, 190),
			Color.FromArgb(237, 199, 165),
			Color.FromArgb( 28,  28,  28),
			Color.FromArgb( 67,  67,  67),
			Color.FromArgb(106, 106, 106), // 130
			Color.FromArgb(145, 145, 145),
			Color.FromArgb(185, 185, 185),
			Color.FromArgb(223, 223, 223),
			Color.FromArgb(247, 247, 247),
			Color.FromArgb(255, 255,   0),
			Color.FromArgb(247, 211, 191),
			Color.FromArgb(248, 201, 138),
			Color.FromArgb(255, 206, 157),
			Color.FromArgb(255, 225, 201),
			Color.FromArgb(255, 238, 217), // 140
			Color.FromArgb(255, 226, 161),
			Color.FromArgb(216, 223, 255),
			Color.FromArgb(255, 255, 243),
			Color.FromArgb( 24,  24,   0),
			Color.FromArgb( 37,  37,  17),
			Color.FromArgb( 27,  47,   0),
			Color.FromArgb( 47,  57,  17),
			Color.FromArgb( 67,  77,   7),
			Color.FromArgb( 77,  77,  47),
			Color.FromArgb( 44,  77,   3), // 150
			Color.FromArgb( 94,  84,  53),
			Color.FromArgb( 95,  97,  39),
			Color.FromArgb( 97,  97,  67),
			Color.FromArgb( 67,  97,  29),
			Color.FromArgb(106, 115,  57),
			Color.FromArgb(116, 115,  75),
			Color.FromArgb( 87, 116,   7),
			Color.FromArgb(118, 130,  65),
			Color.FromArgb(130, 136,  77),
			Color.FromArgb(138, 139,  87), // 160
			Color.FromArgb(148, 155, 100),
			Color.FromArgb(156, 156, 139),
			Color.FromArgb(128, 157,  84),
			Color.FromArgb(149, 166,  97),
			Color.FromArgb(175, 165, 106),
			Color.FromArgb(176, 176, 159),
			Color.FromArgb(146, 176,  67),
			Color.FromArgb(194, 190, 148),
			Color.FromArgb(165, 196, 108),
			Color.FromArgb(166, 196,  77), // 170
			Color.FromArgb(206, 187, 128),
			Color.FromArgb(206, 204, 155),
			Color.FromArgb(204, 217,  77),
			Color.FromArgb(221, 218, 166),
			Color.FromArgb(196, 226, 116),
			Color.FromArgb(243, 170,  92),
			Color.FromArgb(  3,  28,   0),
			Color.FromArgb(  7,  38,   0),
			Color.FromArgb(  7,  47,   7),
			Color.FromArgb( 19,  48,   0), // 180
			Color.FromArgb( 27,  57,  17),
			Color.FromArgb( 47,  57,  47),
			Color.FromArgb( 28,  62,   0),
			Color.FromArgb( 14,  68,  14),
			Color.FromArgb( 41,  69,  28),
			Color.FromArgb( 33,  73,  18),
			Color.FromArgb( 47,  87,  47),
			Color.FromArgb( 77,  97,  57),
			Color.FromArgb( 67,  97,  67),
			Color.FromArgb( 87, 116,  77), // 190
			Color.FromArgb( 70, 119,  48),
			Color.FromArgb(189, 209, 253),
			Color.FromArgb(106, 136,  97),
			Color.FromArgb(196, 236, 166),
			Color.FromArgb( 23,  53,  33),
			Color.FromArgb( 43,  84,  64),
			Color.FromArgb( 37, 116,  57),
			Color.FromArgb( 23,  43,  53),
			Color.FromArgb(  2,  33,  53),
			Color.FromArgb(  2,  23,  53), // 200
			Color.FromArgb( 33,  64,  64),
			Color.FromArgb(  0,  34,  97),
			Color.FromArgb(  0,  51, 115),
			Color.FromArgb( 43,  64,  74),
			Color.FromArgb(  0,  43,  74),
			Color.FromArgb(  4,   6,   9),
			Color.FromArgb(  0, 123, 189),
			Color.FromArgb( 64,  84,  84),
			Color.FromArgb(  0, 115, 207),
			Color.FromArgb( 23,  23,  74), // 210
			Color.FromArgb( 12,  23,  64),
			Color.FromArgb(255, 177,  98),
			Color.FromArgb(  0,  64, 125),
			Color.FromArgb(  2,  23,  84),
			Color.FromArgb(  0, 138, 186),
			Color.FromArgb( 64, 105, 105),
			Color.FromArgb(  0, 146, 197),
			Color.FromArgb( 94, 105, 105),
			Color.FromArgb(  0,  74, 125),
			Color.FromArgb(  0, 125, 207), // 220
			Color.FromArgb( 95, 133,  65),
			Color.FromArgb( 84, 115, 125),
			Color.FromArgb( 64, 105, 125),
			Color.FromArgb(  0,  64, 146),
			Color.FromArgb(  0,  53, 135),
			Color.FromArgb(115, 156, 156),
			Color.FromArgb( 84, 146, 176),
			Color.FromArgb(146, 176, 187),
			Color.FromArgb(255, 201, 121),
			Color.FromArgb(105, 166, 197), // 230
			Color.FromArgb(125, 197, 217),
			Color.FromArgb(156, 197, 217),
			Color.FromArgb(109, 126,  33),
			Color.FromArgb(113, 153,  36),
			Color.FromArgb( 21, 118,  21),
			Color.FromArgb( 51, 151,  39),
			Color.FromArgb( 70, 181,  59),
			Color.FromArgb( 89, 223,  89),
			Color.FromArgb(131, 245, 120),
			Color.FromArgb(152, 192, 240), // 240
			Color.FromArgb(  0, 255,   0),
			Color.FromArgb(  0,   0, 255), // 242 - Outline color
			Color.FromArgb(255, 255,   0),
			Color.FromArgb(255, 217,   0),
			Color.FromArgb(240, 240, 255),
			Color.FromArgb(240, 247, 255),
			Color.FromArgb(247, 247, 255),
			Color.FromArgb(247, 255, 255),
			Color.FromArgb( 85, 119,  52),
			Color.FromArgb(129, 151,  49), // 250
			Color.FromArgb(  0, 255, 255),
			Color.FromArgb(255,   0, 255),
			Color.FromArgb(  0, 139, 210),
			Color.FromArgb(  0, 160, 243),
			Color.FromArgb(255, 255, 255), // 255
		};
	}
}
