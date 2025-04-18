﻿// Write a program, which sorts an array of integer elements using a "merge 
// sort" algorithm.

// Need to complete till Ch-10 Recursion

class SortUsingMergeSort
{
    static void Main()
    {
        int[] array1 = {3, 1, 2, 4, 9, 6};
        int[] array2 = {2, 1, 2, 4, 3, 5, 2, 6};
        int[] array3 = {88, 25, 98, 37, 52, 84, 38, 79, 2, 91, 76, 65, 74, 23, 71, 72, 68, 27, 11, 3, 36, 14, 39, 78, 86, 17, 89, 77, 92, 7, 64, 9, 90, 21, 60, 18, 82, 32, 56, 97, 85, 40, 34, 75, 24, 57, 16, 5, 12, 19, 13, 44, 59, 83, 87, 15, 30, 63, 28, 41, 6, 35, 29, 10, 50, 31, 62, 95, 55, 96, 33, 81, 69, 26, 22, 67, 1, 8, 46, 4, 58, 48, 73, 51, 49, 47, 100, 53, 93, 70, 80, 66, 54, 20, 61, 99, 42, 94, 45, 43};
        int[] array4 = {992, 927, 110, 645, 250, 319, 829, 867, 606, 691, 130, 990, 578, 954, 697, 450, 702, 52, 620, 106, 499, 371, 315, 774, 402, 494, 739, 276, 308, 188, 397, 416, 123, 356, 595, 643, 234, 548, 101, 298, 528, 324, 460, 810, 500, 872, 664, 65, 754, 103, 125, 138, 657, 108, 257, 694, 18, 329, 200, 419, 185, 756, 99, 230, 878, 232, 127, 102, 363, 649, 752, 25, 8, 965, 687, 855, 358, 288, 572, 924, 976, 853, 317, 701, 473, 269, 370, 445, 889, 520, 433, 11, 644, 781, 852, 346, 677, 228, 484, 281, 957, 44, 62, 107, 483, 178, 777, 218, 610, 283, 893, 339, 191, 202, 30, 991, 413, 625, 865, 176, 189, 7, 511, 727, 716, 600, 137, 557, 745, 732, 213, 98, 426, 90, 699, 540, 616, 150, 270, 204, 767, 291, 310, 851, 834, 627, 420, 597, 36, 392, 651, 998, 923, 207, 170, 59, 239, 354, 839, 67, 424, 485, 938, 961, 475, 390, 759, 583, 768, 599, 551, 710, 979, 898, 364, 289, 953, 337, 681, 816, 850, 403, 21, 441, 585, 214, 391, 740, 118, 749, 997, 886, 776, 932, 999, 849, 504, 654, 942, 220, 866, 428, 81, 823, 122, 715, 418, 905, 899, 819, 573, 434, 454, 28, 931, 723, 672, 379, 12, 300, 935, 772, 796, 678, 843, 497, 196, 510, 129, 970, 306, 939, 23, 140, 831, 582, 994, 869, 967, 237, 908, 168, 474, 945, 532, 892, 361, 238, 374, 534, 665, 35, 41, 282, 948, 915, 172, 682, 401, 42, 724, 455, 132, 949, 984, 384, 203, 164, 335, 958, 912, 355, 316, 830, 633, 713, 847, 194, 894, 822, 522, 352, 261, 738, 560, 581, 161, 751, 854, 112, 987, 432, 832, 278, 490, 974, 807, 326, 496, 673, 259, 587, 431, 437, 254, 666, 294, 689, 299, 491, 72, 39, 277, 596, 290, 369, 592, 913, 163, 149, 615, 38, 476, 887, 255, 321, 693, 926, 605, 741, 636, 906, 177, 427, 158, 383, 131, 48, 351, 574, 60, 211, 56, 836, 265, 236, 794, 31, 154, 378, 407, 556, 956, 462, 896, 301, 115, 576, 183, 714, 412, 634, 69, 769, 882, 217, 120, 840, 670, 983, 884, 362, 826, 667, 910, 588, 271, 17, 718, 119, 858, 537, 440, 856, 544, 405, 442, 160, 668, 584, 376, 86, 487, 55, 920, 284, 546, 201, 619, 936, 16, 486, 589, 783, 593, 669, 903, 54, 233, 604, 134, 97, 156, 928, 464, 328, 675, 84, 704, 722, 87, 880, 765, 377, 663, 350, 729, 603, 399, 916, 242, 760, 173, 93, 414, 33, 166, 509, 818, 761, 342, 449, 950, 607, 579, 725, 340, 591, 640, 825, 309, 516, 782, 639, 425, 219, 770, 100, 104, 221, 680, 51, 542, 336, 305, 844, 210, 243, 76, 742, 762, 798, 248, 443, 580, 40, 417, 711, 746, 359, 481, 558, 406, 547, 674, 703, 478, 223, 457, 728, 837, 870, 136, 92, 904, 461, 79, 199, 790, 797, 937, 423, 535, 862, 82, 881, 835, 477, 387, 22, 736, 410, 859, 109, 628, 366, 338, 162, 58, 80, 1, 229, 773, 171, 27, 382, 386, 962, 696, 552, 514, 787, 612, 49, 897, 735, 941, 285, 241, 272, 77, 105, 224, 303, 982, 653, 117, 263, 15, 929, 517, 197, 536, 793, 349, 266, 470, 398, 841, 646, 526, 451, 977, 808, 256, 879, 637, 660, 709, 801, 959, 144, 721, 860, 482, 372, 955, 602, 388, 541, 980, 333, 13, 861, 989, 757, 184, 226, 74, 631, 488, 95, 692, 565, 553, 395, 868, 165, 925, 446, 498, 695, 43, 513, 126, 94, 389, 73, 758, 515, 946, 348, 529, 590, 566, 2, 621, 325, 436, 147, 656, 890, 632, 307, 143, 444, 280, 142, 14, 421, 828, 400, 988, 19, 918, 799, 564, 933, 876, 187, 121, 458, 216, 447, 805, 415, 181, 874, 594, 635, 502, 784, 891, 430, 638, 113, 88, 111, 688, 435, 368, 45, 559, 508, 827, 846, 468, 662, 253, 205, 975, 617, 630, 489, 647, 549, 34, 68, 57, 193, 527, 225, 813, 128, 66, 343, 521, 409, 9, 608, 155, 863, 367, 875, 274, 394, 611, 357, 755, 966, 726, 661, 247, 20, 61, 46, 901, 641, 577, 258, 89, 5, 624, 778, 26, 986, 186, 531, 323, 971, 466, 503, 780, 985, 472, 518, 322, 212, 227, 139, 175, 71, 267, 623, 550, 360, 883, 952, 747, 167, 800, 969, 327, 153, 914, 838, 286, 779, 114, 124, 570, 235, 262, 501, 766, 75, 622, 744, 375, 676, 963, 159, 152, 934, 4, 492, 10, 279, 539, 244, 260, 569, 789, 964, 6, 930, 626, 293, 151, 764, 629, 671, 295, 712, 381, 719, 273, 684, 85, 133, 786, 83, 614, 252, 469, 775, 731, 814, 981, 393, 24, 973, 788, 609, 652, 145, 148, 78, 190, 877, 96, 345, 811, 523, 909, 659, 972, 231, 275, 422, 50, 968, 505, 803, 507, 493, 601, 561, 895, 648, 679, 195, 571, 3, 479, 245, 525, 206, 842, 373, 683, 737, 824, 530, 885, 331, 655, 538, 332, 734, 463, 314, 821, 568, 902, 467, 690, 524, 320, 791, 720, 251, 353, 174, 960, 911, 519, 618, 708, 1000, 658, 465, 802, 404, 555, 586, 730, 943, 302, 429, 313, 448, 944, 215, 947, 453, 900, 471, 208, 833, 268, 296, 385, 917, 922, 182, 753, 438, 135, 845, 47, 613, 700, 264, 249, 439, 705, 456, 919, 575, 506, 495, 804, 748, 562, 146, 116, 888, 857, 169, 512, 396, 698, 717, 334, 685, 993, 312, 795, 180, 411, 873, 996, 978, 707, 141, 292, 817, 686, 408, 91, 543, 311, 848, 459, 380, 642, 563, 37, 209, 198, 480, 287, 940, 809, 598, 533, 792, 341, 157, 567, 733, 318, 32, 29, 347, 806, 812, 815, 921, 864, 907, 297, 743, 820, 365, 951, 53, 763, 192, 330, 554, 64, 70, 750, 240, 179, 304, 452, 344, 995, 771, 871, 706, 785, 545, 222, 246, 63, 650};
        
        int[] sorted = Sort(array3);

        Console.WriteLine("Given array:");
        PrintArray(array3);
        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        PrintArray(sorted);
        Console.WriteLine();
        Console.WriteLine("Given array:");
        PrintArray(array3);
    }


    static int[] Sort(int[] myArray)
    {
        // Method to return sorted array from given array

        int len = myArray.Length;
        int[] wArray = new int[len];
        int[] sorted = new int[len];

        CopyValues(wArray, myArray);
        CopyValues(sorted, myArray);
        MergeSort(sorted, wArray, 0, len);
        
        return sorted;
    }


    static void MergeSort(int[] sorted, int[] wArray, int start, int end)
    {
        // Method to sort wArray into sorted array using merge sort
        // wArray and sorted array change places in subsequent recursive calls
        // i.e. sorted array becomes wArray
        // and wArray becomes sorted array
        // And
        // start is inclusive
        // end is exclusive

        int mid = (end - start) / 2;

        if(mid == 0)
        {
            return;
        }

        mid += start;
        MergeSort(wArray, sorted, start, mid); // Call MergeSort on left half
        MergeSort(wArray, sorted, mid, end); // Call MergeSort on right half
        Merge(sorted, wArray, start, mid, end); // Call Merge to sort wArray into sorted array
    }


    static void Merge(int[] sorted, int[] wArray, int start, int mid, int end)
    {
        // Sort and merge left and right half from wArray to sorted array
        // left half[start, mid] (start is inclusive and mid is exclusive)
        // right half[mid, end] (mid is inclusive and end is exclusive)

        int i = start;
        int j = mid;

        for(int k = start; k < end; k++)
        {
            if(i < mid && (j >= end || wArray[i] < wArray[j]))
            {
                sorted[k] = wArray[i];
                i += 1;
            }
            else
            {
                sorted[k] = wArray[j];
                j += 1;
            }
        }
    }


    static void CopyValues(int[] A, int[] B)
    {
        // Method to copy values from B to A
        // Both arrays should be of same length

        for(int i = 0; i < A.Length; i++)
        {
            A[i] = B[i];
        }
    }


    static void PrintArray(int[] myArray)
    {
        // Method to print given array

        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }
}