package hnn40;

import javax.swing.JOptionPane;

public class Algs180 {
	
	private final int TNODE = 9; //number of nodes to reach destination
	private final int NODE = 182; //number of nodes in total
	
	private int[] SD = new int[TNODE]; //stores the nodes to be accessed 
	private int SD_order[][] = new int[TNODE][NODE]; //???
	
	private double cost[][] = new double[NODE][NODE]; //cost between each node
	private int gamma[][]= new int[NODE][NODE]; // ???
	
	private  double U[][] = new double[NODE][NODE];
	private  double V[][] = new double[NODE][NODE];
	
	private final int LAMBDA = 1;
	private final double DELTA = 0.0001;
	private final int TAU=1;
	
	private final int A=950;
	private final int B=2500;
	private final int C=1900;
	private final int D=100;
	private final int F=500;
        
        //
        private final  int ALI_Mu1=550;
	private final  int ALI_Mu2=2550;
	private final  int ALI_Mu3=1950;
	private final  int ALI_Mu4=250;
	private final  int ALI_Mu5=1350;
	
        private final  int PARK_A = 550;
        private final  int PARK_B = 2550;
        private final  int PARK_C = 1500;
        private final  int PARK_D = 250;
        private final  int PARK_F = 1350;
	
        private final  int Mu1 = 950;
        private final  int Mu2 = 2500;
        private final  int Mu3 = 1500;
        private final  int Mu4 = 475;
        private final  int Mu5 = 500;
        private final  int Mu6 = 400;
        private final  int Mu7 = 400;
        
	
	public void Loading_Source_Destination(int node, int tnode){
		
		//nodes to be accessed
		SD[0]=1;
                SD[1]=4;
                SD[2]=8;
                SD[3]=16;
                SD[4]=32;
                SD[5]=38;
                SD[6]=43;
                SD[7]=48;
                SD[8]=52;
              
        
               
                
    
        
		for (int i=0; i<tnode; i++) {
			for (int j=0; j<node; j++) {
				SD_order[i][j]=-10; // set initial SD to -10
			}
		}
	
	}
	
	
	private void Loading_Link_Information(int node){
	
		for (int i=0; i<node; i++) {
			for (int j=0; j<node; j++){
				cost[i][j]=-1.0; //set initial cost between all nodes to -1
				gamma[i][j]=1; //set gamma to 1
			}
		}
		
cost   	[0]	[1]	= 477 		;
cost   	[1]	[0]	= 825		;
cost   	[0]	[2]	= 122		;
cost   	[2]	[0]	= 394		;
cost   	[0]	[10]	= 503		;
cost   	[10]	[0]	= 995		;
cost   	[0]	[9]	= 636		;
cost   	[9]	[0]	= 125		;
cost   	[0]	[8]	= 688		;
cost   	[8]	[0]	= 483		;
cost   	[1]	[12]	= 855		;
cost   	[12]	[1]	= 119		;
cost   	[1]	[11]	= 76		;
cost   	[11]	[1]	= 497		;
cost   	[2]	[24]	= 205		;
cost   	[24]	[2]	= 821		;
cost   	[3]	[13]	= 977		;
cost   	[13]	[3]	= 330		;
cost   	[3]	[4]	= 235		;
cost   	[4]	[3]	= 210		;
cost   	[4]	[14]	= 860		;
cost   	[14]	[4]	= 423		;
cost   	[4]	[5]	= 436		;
cost   	[5]	[4]	= 534		;
cost   	[5]	[6]	= 576		;
cost   	[6]	[5]	= 765	 	;
cost   	[5]	[16]	= 871		;
cost   	[16]	[5]	= 558		;
cost   	[6]	[7]	= 309		;
cost   	[7]	[6]	= 829		;
cost   	[6]	[17]	= 86		;
cost   	[17]	[6]	= 992		;
cost   	[7]	[8]	= 370		;
cost   	[8]	[7]	= 276		;
cost   	[7]	[18]	= 266		;
cost   	[18]	[7]	= 650		;
cost   	[8]	[9]	= 172		;
cost   	[9]	[8]	= 680		;
cost   	[8]	[19]	= 51		;
cost   	[19]	[8]	= 347		;
cost   	[9]	[10]	= 505		;
cost   	[10]	[9]	= 746		;
cost   	[9]	[22]	= 664		;
cost   	[22]	[9]	= 319		;
cost   	[9]	[21]	= 736		;
cost   	[21]	[9]	= 33		;
cost   	[9]	[20]	= 59		;
cost   	[20]	[9]	= 551		;
cost   	[10]	[11]	= 451		;
cost   	[11]	[10]	= 817		;
cost   	[11]	[23]	= 233		;
cost   	[23]	[11]	= 327		;
cost   	[11]	[22]	= 722		;
cost   	[22]	[11]	= 106		;
cost   	[12]	[23]	= 260		;
cost   	[23]	[12]	= 2		;
cost   	[12]	[24]	= 993		;
cost   	[24]	[12]	= 609		;
cost   	[13]	[24]	= 893		;
cost   	[24]	[13]	= 667		;
cost   	[13]	[14]	= 375		;
cost   	[14]	[13]	= 954		;
cost   	[14]	[25]	= 749		;
cost   	[25]	[14]	= 655		;
cost   	[14]	[15]	= 961		;
cost   	[15]	[14]	= 469		;
cost   	[14]	[16]	= 111		;
cost   	[16]	[14]	= 384		;
cost   	[15]	[16]	= 938		;
cost   	[16]	[15]	= 555		;
cost   	[15]	[25]	= 235		;
cost   	[25]	[15]	= 86		;
cost   	[15]	[47]	= 110		;
cost   	[47]	[15]	= 187		;
cost   	[16]	[17]	= 206		;
cost   	[17]	[16]	= 519		;
cost   	[16]	[46]	= 725		;
cost   	[46]	[16]	= 536		;
cost   	[17]	[18]	= 483		;
cost   	[18]	[17]	= 242		;
cost   	[18]	[19]	= 471		;
cost   	[19]	[18]	= 175		;
cost   	[18]	[45]	= 285		;
cost   	[45]	[18]	= 434		;
cost   	[19]	[20]	= 31		;
cost   	[20]	[19]	= 881		;
cost   	[20]	[52]	= 808		;
cost   	[52]	[20]	= 599		;
cost   	[20]	[60]	= 76		;
cost   	[60]	[20]	= 818		;
cost   	[22]	[21]	= 669		;
cost   	[21]	[22]	= 269		;
cost   	[21]	[52]	= 987		;
cost   	[52]	[21]	= 356		;
cost   	[52]	[53]	= 88		;
cost   	[53]	[52]	= 221		;
cost   	[52]	[59]	= 768		;
cost   	[59]	[52]	= 957		;
cost   	[53]	[54]	= 836		;
cost   	[54]	[53]	= 491		;
cost   	[54]	[55]	= 849		;
cost   	[55]	[54]	= 699		;
cost   	[55]	[57]	= 879		;
cost   	[57]	[55]	= 65		;
cost   	[57]	[58]	= 601		;
cost   	[58]	[57]	= 304		;
cost   	[57]	[63]	= 996		;
cost   	[63]	[57]	= 735		;
cost   	[58]	[56]	= 491		;
cost   	[56]	[58]	= 178		;
cost   	[58]	[59]	= 276		;
cost   	[59]	[58]	= 816		;
cost   	[59]	[60]	= 908		;
cost   	[60]	[59]	= 525		;
cost   	[60]	[65]	= 202		;
cost   	[65]	[60]	= 606		;
cost   	[60]	[64]	= 433		;
cost   	[64]	[60]	= 175		;
cost   	[60]	[61]	= 920		;
cost   	[61]	[60]	= 554		;
cost   	[61]	[62]	= 544		;
cost   	[62]	[61]	= 733		;
cost   	[63]	[64]	= 406		;
cost   	[64]	[63]	= 689		;
cost   	[64]	[65]	= 888		;
cost   	[65]	[64]	= 341		;
cost   	[65]	[66]	= 934		;
cost   	[66]	[65]	= 370		;
cost   	[66]	[67]	= 579		;
cost   	[67]	[66]	= 963		;
cost   	[67]	[68]	= 901		;
cost   	[68]	[67]	= 2		;
cost   	[68]	[69]	= 689		;
cost   	[69]	[68]	= 237		;
cost   	[68]	[71]	= 227		;
cost   	[71]	[68]	= 806		;
cost   	[71]	[44]	= 488		;
cost   	[44]	[71]	= 776		;
cost   	[71]	[43]	= 736		;
cost   	[43]	[71]	= 196		;
cost   	[71]	[73]	= 470		;
cost   	[73]	[71]	= 352		;
cost   	[71]	[70]	= 985		;
cost   	[70]	[71]	= 10		;
cost   	[73]	[72]	= 270		;
cost   	[72]	[73]	= 13		;
cost   	[72]	[42]	= 947		;
cost   	[42]	[72]	= 683		;
cost   	[72]	[74]	= 642		;
cost   	[74]	[72]	= 719		;
cost   	[74]	[41]	= 514		;
cost   	[41]	[74]	= 257		;
cost   	[74]	[75]	= 540		;
cost   	[75]	[74]	= 617		;
cost   	[75]	[76]	= 106		;
cost   	[76]	[75]	= 848		;
cost   	[76]	[77]	= 894		;
cost   	[77]	[76]	= 689		;
cost   	[77]	[39]	= 715		;
cost   	[39]	[77]	= 897		;
cost   	[25]	[51]	= 518		;
cost   	[51]	[25]	= 313		;
cost   	[26]	[27]	= 942		;
cost   	[27]	[26]	= 949		;
cost   	[26]	[28]	= 180		;
cost   	[28]	[26]	= 672		;
cost   	[26]	[29]	= 39		;
cost   	[29]	[26]	= 635		;
cost   	[26]	[30]	= 749		;
cost   	[30]	[26]	= 491		;
cost   	[26]	[31]	= 944		;
cost   	[31]	[26]	= 435		;
cost   	[26]	[32]	= 211		;
cost   	[32]	[26]	= 866		;
cost   	[27]	[28]	= 297		;
cost   	[28]	[27]	= 749		;
cost   	[27]	[33]	= 589		;
cost   	[33]	[27]	= 468		;
cost   	[27]	[34]	= 318		;
cost   	[34]	[27]	= 943		;
cost   	[28]	[29]	= 7		;
cost   	[29]	[28]	= 818		;
cost   	[29]	[37]	= 425		;
cost   	[37]	[29]	= 526		;
cost   	[29]	[30]	= 880		;
cost   	[30]	[29]	= 138		;
cost   	[30]	[39]	= 340		;
cost   	[39]	[30]	= 277		;
cost   	[30]	[31]	= 148		;
cost   	[31]	[30]	= 548		;
cost   	[30]	[41]	= 756		;
cost   	[41]	[30]	= 603		;
cost   	[31]	[32]	= 558		;
cost   	[32]	[31]	= 763		;
cost   	[32]	[33]	= 741		;
cost   	[33]	[32]	= 445		;
cost   	[32]	[42]	= 679		;
cost   	[42]	[32]	= 781		;
cost   	[33]	[34]	= 650		;
cost   	[34]	[33]	= 158		;
cost   	[33]	[34]	= 315		;
cost   	[44]	[33]	= 417		;
cost   	[34]	[35]	= 778		;
cost   	[35]	[34]	= 537		;
cost   	[34]	[47]	= 528		;
cost   	[47]	[34]	= 880		;
cost   	[35]	[48]	= 941		;
cost   	[48]	[35]	= 867		;
cost   	[35]	[50]	= 778		;
cost   	[50]	[35]	= 231		;
cost   	[35]	[36]	= 553		;
cost   	[36]	[35]	= 93		;
cost   	[36]	[37]	= 963		;
cost   	[37]	[36]	= 831		;
cost   	[37]	[82]	= 491		;
cost   	[82]	[37]	= 749		;
cost   	[37]	[38]	= 123		;
cost   	[38]	[37]	= 544		;
cost   	[38]	[83]	= 376		;
cost   	[83]	[38]	= 438		;
cost   	[38]	[39]	= 390		;
cost   	[39]	[38]	= 898		;
cost   	[39]	[86]	= 762		;
cost   	[86]	[39]	= 183		;
cost   	[39]	[40]	= 772		;
cost   	[40]	[39]	= 980		;
cost   	[40]	[41]	= 492		;
cost   	[41]	[40]	= 195		;
cost   	[41]	[42]	= 264		;
cost   	[42]	[41]	= 577		;
cost   	[42]	[43]	= 643		;
cost   	[43]	[42]	= 737		;
cost   	[43]	[44]	= 551		;
cost   	[44]	[43]	= 60		;
cost   	[44]	[45]	= 874		;
cost   	[45]	[44]	= 686		;
cost   	[45]	[46]	= 981		;
cost   	[46]	[45]	= 207		;
cost   	[46]	[47]	= 360		;
cost   	[47]	[46]	= 760		;
cost   	[47]	[48]	= 934		;
cost   	[48]	[47]	= 247		;
cost   	[48]	[49]	= 954		;
cost   	[49]	[48]	= 267		;
cost   	[49]	[50]	= 277		;
cost   	[50]	[49]	= 566		;
cost   	[50]	[51]	= 684		;
cost   	[51]	[50]	= 582		;
cost   	[50]	[78]	= 280		;
cost   	[78]	[50]	= 20		;
cost   	[78]	[98]	= 392		;
cost   	[98]	[78]	= 8		;
cost   	[78]	[79]	= 369		;
cost   	[79]	[78]	= 55		;
cost   	[79]	[80]	= 687		;
cost   	[80]	[79]	= 593		;
cost   	[80]	[98]	= 340		;
cost   	[98]	[80]	= 187		;
cost   	[80]	[96]	= 790		;
cost   	[96]	[80]	= 158		;
cost   	[80]	[80]	= 419		;
cost   	[81]	[81]	= 976		;
cost   	[81]	[95]	= 71		;
cost   	[95]	[81]	= 938		;
cost   	[81]	[82]	= 814		;
cost   	[82]	[81]	= 680		;
cost   	[82]	[93]	= 756		;
cost   	[93]	[82]	= 798		;
cost   	[82]	[83]	= 419		;
cost   	[83]	[82]	= 716		;
cost   	[83]	[93]	= 170		;
cost   	[93]	[83]	= 427		;
cost   	[83]	[91]	= 252		;
cost   	[91]	[83]	= 126		;
cost   	[83]	[84]	= 901		;
cost   	[84]	[83]	= 393		;
cost   	[84]	[90]	= 28		;
cost   	[90]	[84]	= 592		;
cost   	[84]	[85]	= 217		;
cost   	[85]	[84]	= 904		;
cost   	[85]	[86]	= 86 		;
cost   	[86]	[85]	= 44		;
cost   	[86]	[87]	= 450		;
cost   	[87]	[86]	= 942		;
cost   	[86]	[88]	= 520		;
cost   	[88]	[86]	= 224		;
cost   	[88]	[87]	= 29		;
cost   	[87]	[88]	= 537		;
cost   	[88]	[89]	= 905		;
cost   	[89]	[88]	= 645		;
cost   	[88]	[113]	= 130		;
cost   	[113]	[88]	= 889		;
cost   	[89]	[113]	= 97		;
cost   	[113]	[89]	= 661		;
cost   	[89]	[90]	= 894		;
cost   	[90]	[89]	= 191		;
cost   	[90]	[91]	= 982		;
cost   	[91]	[90]	= 598		;
cost   	[91]	[111]	= 980		;
cost   	[111]	[91]	= 794		;
cost   	[91]	[92]	= 359		;
cost   	[92]	[91]	= 349		;
cost   	[92]	[93]	= 141		;
cost   	[93]	[92]	= 740 		;
cost   	[93]	[109]	= 294		;
cost   	[109]	[93]	= 858		;
cost   	[93]	[94]	= 694		;
cost   	[94]	[93]	= 740		;
cost   	[94]	[103]	= 617		;
cost   	[103]	[94]	= 998		;
cost   	[94]	[95]	= 292		;
cost   	[95]	[94]	= 199		;
cost   	[95]	[102]	= 842		;
cost   	[102]	[95]	= 992		;
cost   	[95]	[96]	= 312		;
cost   	[96]	[95]	= 664		;
cost   	[96]	[97]	= 490		;
cost   	[97]	[96]	= 146		;
cost   	[97]	[98]	= 28		;
cost   	[98]	[97]	= 823		;
cost   	[97]	[99]	= 791		;
cost   	[99]	[97]	= 658		;
cost   	[97]	[102]	= 185		;
cost   	[102]	[97]	= 758		;
cost   	[99]	[100]	= 918		;
cost   	[100]	[99]	= 817		;
cost   	[100]	[104]	= 382		;
cost   	[104]	[100]	= 818		;
cost   	[100]	[101]	= 632		;
cost   	[101]	[100]	= 140		;
cost   	[101]	[107]	= 16		;
cost   	[107]	[101]	= 6		;
cost   	[101]	[102]	= 955		;
cost   	[102]	[101]	= 658		;
cost   	[102]	[103]	= 919		;
cost   	[103]	[102]	= 291	 	;
cost   	[104]	[105]	= 808		;
cost   	[105]	[104]	= 300		;
cost   	[105]	[106]	= 736		;
cost   	[106]	[105]	= 834		;
cost   	[106]	[120]	= 362		;
cost   	[120]	[106]	= 316		;
cost   	[106]	[107]	= 488		;
cost   	[107]	[106]	= 442		;
cost   	[107]	[108]	= 412		;
cost   	[108]	[107]	= 709		;
cost   	[108]	[119]	= 346		;
cost   	[119]	[108]	= 248		;
cost   	[108]	[118]	= 857		;
cost   	[118]	[108]	= 567		;
cost   	[108]	[109]	= 504		;
cost   	[109]	[108]	= 549		;
cost   	[109]	[110]	= 874		;
cost   	[110]	[109]	= 725		;
cost   	[109]	[111]	= 939		;
cost   	[111]	[109]	= 923		;
cost   	[111]	[112]	= 395		;
cost   	[112]	[111]	= 219		;
cost   	[111]	[116]	= 838		;
cost   	[116]	[111]	= 346		;
cost   	[112]	[115]	= 483		;
cost   	[115]	[112]	= 741		;
cost   	[112]	[113]	= 876		;
cost   	[113]	[112]	= 173		;
cost   	[113]	[114]	= 315		;
cost   	[114]	[113]	= 611		;
cost   	[114]	[115]	= 689		;
cost   	[115]	[114]	= 734		;
cost   	[115]	[129]	= 914		;
cost   	[129]	[115]	= 314		;
cost   	[115]	[116]	= 366		;
cost   	[116]	[115]	= 826		;
cost   	[116]	[128]	= 776		;
cost   	[128]	[116]	= 17		;
cost   	[116]	[117]	= 596		;
cost   	[117]	[116]	= 300		;
cost   	[116]	[129]	= 341		;
cost   	[129]	[116]	= 638		;
cost   	[117]	[127]	= 123		;
cost   	[127]	[117]	= 778		;
cost   	[117]	[110]	= 447		;
cost   	[110]	[117]	= 688		;
cost   	[117]	[118]	= 196		;
cost   	[118]	[117]	= 759		;
cost   	[118]	[126]	= 22		;
cost   	[126]	[118]	= 12		;
cost   	[118]	[119]	= 868		;
cost   	[119]	[118]	= 268		;
cost   	[119]	[125]	= 389		;
cost   	[125]	[119]	= 789		;
cost   	[119]	[120]	= 392		;
cost   	[120]	[119]	= 915		;
cost   	[120]	[123]	= 214		;
cost   	[123]	[120]	= 64		;
cost   	[120]	[121]	= 885		;
cost   	[121]	[120]	= 593		;
cost   	[121]	[122]	= 778		;
cost   	[122]	[121]	= 410		;
cost   	[122]	[130]	= 910		;
cost   	[130]	[122]	= 346		;
cost   	[122]	[123]	= 455		;
cost   	[123]	[122]	= 557		;
cost   	[123]	[131]	= 418		;
cost   	[131]	[123]	= 874		;
cost   	[123]	[124]	= 798		;
cost   	[124]	[123]	= 289		;
cost   	[124]	[133]	= 721		;
cost   	[133]	[124]	= 532		;
cost   	[124]	[125]	= 89		;
cost   	[125]	[124]	= 829		;
cost   	[125]	[135]	= 870		;
cost   	[135]	[125]	= 609		;
cost   	[125]	[126]	= 907		;
cost   	[126]	[125]	= 611		;
cost   	[126]	[135]	= 227		;
cost   	[135]	[126]	= 94		;
cost   	[126]	[127]	= 591		;
cost   	[127]	[126]	= 816		;
cost   	[127]	[137]	= 536		;
cost   	[137]	[127]	= 654		;
cost   	[127]	[128]	= 856		;
cost   	[128]	[127]	= 152		;
cost   	[128]	[140]	= 177		;
cost   	[140]	[128]	= 131		;
cost   	[128]	[129]	= 637		;
cost   	[129]	[128]	= 770		;
cost   	[130]	[131]	= 838		;
cost   	[131]	[130]	= 134		;
cost   	[131]	[132]	= 551		;
cost   	[132]	[131]	= 42		;
cost   	[132]	[152]	= 324		;
cost   	[152]	[132]	= 888		;
cost   	[132]	[133]	= 33		;
cost   	[133]	[132]	= 329		;
cost   	[133]	[134]	= 124		;
cost   	[134]	[133]	= 225		;
cost   	[134]	[135]	= 801		;
cost   	[135]	[134]	= 293		;
cost   	[135]	[149]	= 546		;
cost   	[149]	[135]	= 90		;
cost   	[135]	[148]	= 260		;
cost   	[148]	[135]	= 664		;
cost   	[135]	[136]	= 196		;
cost   	[136]	[135]	= 687		;
cost   	[135]	[147]	= 328		;
cost   	[147]	[135]	= 876		;
cost   	[136]	[137]	= 869		;
cost   	[137]	[136]	= 915		;
cost   	[137]	[138]	= 527		;
cost   	[138]	[137]	= 520 		;
cost   	[138]	[145]	= 833		;
cost   	[145]	[138]	= 537		;
cost   	[138]	[139]	= 315		;
cost   	[139]	[138]	= 361		;
cost   	[139]	[142]	= 351		;
cost   	[143]	[139]	= 218		;
cost   	[139]	[140]	= 992		;
cost   	[140]	[139]	= 484		;
cost   	[140]	[142]	= 24		;
cost   	[142]	[140]	= 766		;
cost   	[140]	[141]	= 593		;
cost   	[141]	[140]	= 803		;
cost   	[142]	[143]	= 139		;
cost   	[143]	[142]	= 843		;
cost   	[143]	[144]	= 9		;
cost   	[144]	[143]	= 179		;
cost   	[144]	[145]	= 296		;
cost   	[145]	[144]	= 107		;
cost   	[145]	[179]	= 610		;
cost   	[179]	[145]	= 261		;
cost   	[145]	[146]	= 117		;
cost   	[146]	[145]	= 538		;
cost   	[146]	[147]	= 799		;
cost   	[147]	[146]	= 502		;
cost   	[146]	[173]	= 521		;
cost   	[173]	[146]	= 671		;
cost   	[148]	[167]	= 977		;
cost   	[167]	[148]	= 274		;
cost   	[148]	[149]	= 853		;
cost   	[149]	[148]	= 759		;
cost   	[149]	[164]	= 766		;
cost   	[164]	[149]	= 915		;
cost   	[149]	[150]	= 690		;
cost   	[150]	[149]	= 520		;
cost   	[150]	[151]	= 761		;
cost   	[151]	[150]	= 503		;
cost   	[151]	[152]	= 797		;
cost   	[152]	[151]	= 595		;
cost   	[151]	[161]	= 505		;
cost   	[161]	[151]	= 802		;
cost   	[152]	[153]	= 509		;
cost   	[153]	[152]	= 611		;
cost   	[152]	[154]	= 668		;
cost   	[154]	[152]	= 104		;
cost   	[152]	[155]	= 744		;
cost   	[155]	[152]	= 535		;
cost   	[154]	[158]	= 55		;
cost   	[158]	[154]	= 10		;
cost   	[155]	[157]	= 137		;
cost  	[157]	[155]	= 542		;
cost   	[160]	[156]	= 625		;
cost   	[156]	[160]	= 687		;
cost   	[160]	[159]	= 256		;
cost   	[158]	[160]	= 912		;
cost   	[160]	[159]	= 850		;
cost   	[159]	[160]	= 481		;
cost   	[160]	[162]	= 331		;
cost   	[162]	[160]	= 520		;
cost   	[160]	[163]	= 370		;
cost   	[163]	[160]	= 364		;
cost   	[159]	[162]	= 832		;
cost   	[162]	[159]	= 985		;
cost   	[163]	[161]	= 187		;
cost   	[161]	[163]	= 484		;
cost   	[163]	[166]	= 652		;
cost   	[166]	[163]	= 144		;
cost   	[163]	[165]	= 421		;
cost   	[165]	[163]	= 216		;
cost   	[161]	[164]	= 322		;
cost   	[164]	[161]	= 189		;
cost   	[164]	[165]	= 314		;
cost   	[165]	[164]	= 698		;
cost   	[164]	[167]	= 510		;
cost   	[167]	[164]	= 931		;
cost   	[165]	[168]	= 477		;
cost   	[168]	[165]	= 595		;
cost   	[166]	[169]	= 688		;
cost   	[169]	[166]	= 165		;
cost   	[168]	[167]	= 995		;
cost   	[167]	[168]	= 221		;
cost   	[168]	[169]	= 132		;
cost   	[169]	[168]	= 872		;
cost   	[168]	[171]	= 414		;
cost   	[171]	[168]	= 819		;
cost   	[170]	[167]	= 993		;
cost   	[167]	[170]	= 641		;
cost   	[170]	[171]	= 799		;
cost   	[171]	[170]	= 307		;
cost   	[170]	[173]	= 830		;
cost   	[173]	[170]	= 736		;
cost   	[169]	[172]	= 343		;
cost   	[172]	[169]	= 173		;
cost   	[175]	[172]	= 323		;
cost   	[172]	[175]	= 10		;
cost   	[175]	[171]	= 668		;
cost   	[171]	[175]	= 284		;
cost   	[175]	[174]	= 791		;
cost   	[174]	[175]	= 244		;
cost   	[175]	[177]	= 358		;
cost   	[177]	[175]	= 726		;
cost   	[175]	[178]	= 915		;
cost   	[178]	[175]	= 228		;
cost   	[174]	[173]	= 309		;
cost   	[173]	[174]	= 264		;
cost   	[174]	[176]	= 31		;
cost   	[176]	[174]	= 257		;
cost   	[174]	[177]	= 726		;
cost   	[177]	[174]	= 859		;
cost   	[176]	[179]	= 376		;
cost   	[179]	[176]	= 673		;
cost   	[179]	[180]	= 357		;
cost   	[180]	[179]	= 489		;
cost   	[177]	[180]	= 968		;
cost   	[180]	[177]	= 30		;
cost   	[177]	[181]	= 150		;
cost   	[181]	[177]	= 945		;
cost   	[180]	[181]	= 14		;
cost   	[181]	[180]	= 7		;
cost   	[178]	[181]	= 935		;
cost   	[181]	[178]	= 356		;
		
			for (int i=0; i<node; i++){
			for (int j=0; j<node; j++){
				//if cost is -1 (no value has been set) set cost to 1 
				if (cost[i][j]==-1.0){
					cost[i][j]=1.0;
					//gamma[i][j]=1;
				}
				else {
				//if cost is set divide it by 10,000 and set gamma to zero
					cost[i][j]/=10000.0;
					gamma[i][j]=0;
				}
			}
		}
	}
	
	
	private void Initialize_Value(int node){
		for(int i=0 ; i<node ; i++){
			for(int j=0 ; j<node ; j++){
				U[i][j]=0.0;
				V[i][j]=Sigmoid_Function(U[i][j]); //initially all set to 0.5
			}
		}
	}
	
	private double Sigmoid_Function(double in){
		return (1/(1+Math.exp(-LAMBDA*in)));
	}
	
	
	private void Pro_Hopfield_NN (int s, int d, int Node){
		for(int i=0 ; i<Node ; i++){
			for(int j=0 ; j<Node ; j++){
				U[i][j]=Pro_Update_Function(i,j,s,d,Node);
				V[i][j]=Sigmoid_Function(U[i][j]);
			}
		}
	}
	
	
	private double Pro_Update_Function(int i, int j, int s, int d, int node)
	{
		double value=0.0;
		
		value = U[i][j] + DELTA*(-U[i][j]/(double)TAU
	                             - 0.5*A*Pro_A_Term(i,j,node)
	                             - 0.5*B*Pro_B_Term(i,j)
	                             - C*Pro_C_first_Term(i,s,d,node)
	                             + C*Pro_C_second_Term(j,s,d,node)
	                             - 0.5*D*Pro_D_Term(i,j)
	                             - 0.5*F*Pro_F_Term(i,j,node)

	                             - 0.5*A*cost[i][j]
	                             - 0.5*B*(double)gamma[i][j]
	                             + C*PHI_Value(i,s,d)
	                             - C*PHI_Value(j,s,d)
	                             - 0.5*D );
		return(value);
	}
	
	private double Pro_A_Term(int i, int j, int node)
	{
		 int k;
		 double value=0.0;

		 for(k=0 ; k<node ; k++){
			 if(k!=i)
				 value += (1.0 - cost[i][k])*cost[i][j];
		 }

		 return(value);
	}
	
	
	private double PHI_Value(int a, int s, int d)
	{
		double value;

		if(a==s)
			value=1.0;
		else if(a==d)
			value=-1.0;
		else
			value=0.0;
		
		return(value);
	}
	

	private double Pro_B_Term(int i, int j)
	{
		return( (double)gamma[i][j] );

	}

	private double Pro_C_first_Term(int i, int s, int d, int node)
	{
		int k;
	    double sum=0.0;

	    for(k=0 ; k<node ; k++){
			if(k!=i)
				sum+=(V[i][k]-V[k][i]);
		}
		return(sum - PHI_Value(i,s,d));
	}

	private double Pro_C_second_Term(int j, int s, int d, int node)
	{
		int k;
	    double sum=0.0;

	    for(k=0 ; k<node ; k++){
			if(k!=j)
				sum+=(V[j][k]-V[k][j]);
		}
		
		return(sum - PHI_Value(j,s,d));
	}

	private double Pro_D_Term(int i, int j)
	{
		return( 1.0- 2.0*V[i][j] );
	}

	private double Pro_F_Term(int i, int j, int node)
	{
		int k;
	    double value=0.0;

		for(k=0 ; k<node ; k++){
			value += (double)gamma[i][k] * V[k][i];
		}

		return(value);
	}
	
	private int Check_Valid_Path(int order, int number, int s, int d)
	{
		int i , j;
		int visit=-1 , count=0 , position=0 , value=0;

		for(i=0 ; i<number ; i++){
			if(V[s][i]>0.8){
				SD_order[order][0]=s;
				SD_order[order][1]=i;
				visit=i;
				position=i;
				count=3;
			}
		}

		if(d==visit){
			value=visit;
		}
		
		else{
			for(i=0 ; i<number-2 ; i++){
				for(j=0 ; j<number ; j++){
					
					if(V[position][j]>0.8){
						if(d==j){
							SD_order[order][count-1]=j;
							visit=j;
							value=visit;
						}
						else{
							SD_order[order][count-1]=j;
							count++;
							position=j;
						}
					}
				}
			}
		}
		
		return(value);
	}
	
	private int Path_Count(int order, int number)
	{
		int i , count=0;
		
		for(i=0 ; i<number ; i++){
			if(SD_order[order][i]!=-10)
				count++;
		}
		return(count);
	}
	
	private double cost_Value_Save(int order, int count)
	{
		int i;
		double cost_sum=0.0;

		for(i=0 ; i<count-1 ; i++){
			cost_sum+=cost[SD_order[order][i]][SD_order[order][i+1]];
		}
		return(cost_sum);
	}
	
	private String trimChar(char[] temp){
		String result = new String();
		for (int i=0; i<temp.length; i++){
			if (String.valueOf(temp[i])=="") 
				result+=temp[i];
		}
		return result;
	}
	
	public  void Pro(){
		
		
		int order; //used in loop, repeats according to TNODE
		int number=0;
		int epoch=0; // how much time is allowed to try to find convergence
		int check=-1;
		double t_cost=0.0;
		int count;
		int ii, jj;
		char name[] = new char[200];
		char name1[] = new char[10];
		
		Loading_Source_Destination(NODE,TNODE);
		Loading_Link_Information(NODE);
		
		//loop will be repeated to number of nodes required to traverse
		for (order=0; order<TNODE-1; order++){
			number = NODE; //set number to amount of nodes
			Initialize_Value(NODE); //set the values of arrays U and V
			epoch = 0; 
			
			
			while (SD[order+1]-1!=check && epoch<=90005){
				epoch++;
				Pro_Hopfield_NN(SD[order]-1, SD[order+1]-1, number);
				check=Check_Valid_Path(order,number,SD[order]-1,SD[order+1]-1);
			}
			
		
			if (epoch>=90000){
				JOptionPane.showMessageDialog (null,"No Convergence");
				break;
			}
			
			count=Path_Count(order,number);
			t_cost+=cost_Value_Save(order,count);
			
		}
		
			
		
		if(epoch<90000){
			for(jj=0 ; jj<TNODE-1 ; jj++){
				for(ii=0 ; ii<number ; ii++){
					if(jj==0){
						if(SD_order[jj][ii]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+"" + (SD_order[jj][ii]+1)+ "->");
							
						}
					}
					
					else if(jj==TNODE-1){
						if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]==-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+""+(SD_order[jj][ii+1]+1));
						
						}
						else if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1) +" " +(SD_order[jj][ii+1]+1)+"->");
							
						}
					}
				
					else{
						if(SD_order[jj][ii+1]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+" "+(SD_order[jj][ii+1]+1)+" ->");
							
						}
						else
							break;
					}			
				}
			}
		}
		
		
		JOptionPane.showMessageDialog (null,"cost"+(t_cost*10000.0));
		JOptionPane.showMessageDialog (null,"Proposed Algorithm finised.");
		
		
		
	}
        private   double Kronecker_Delta(int i, int j)
	{
		 return( (i==j)?1:0 );
	}
	
	private   double Ali_Mu1_Term(int x, int i, int s, int d)
	{
		return( cost[x][i] * (1.0 - Kronecker_Delta(x,d)*Kronecker_Delta(i,s)) );
	}

	private   double Ali_Mu2_Term(int x, int i, int s, int d)
	{
		return( (double)gamma[x][i] * (1.0 - Kronecker_Delta(x,d)*Kronecker_Delta(i,s)) );
	}

	private   double Ali_Mu3_first_Term(int x, int Node)
	{
		int y;
		double Value=0.0;
		
		for(y=0 ; y<Node ; y++){
			if(y!=x){
				Value+=(V[x][y] - V[y][x]);
			}
		}
		return(Value);
	}

	private   double Ali_Mu3_second_Term(int i, int Node)
	{
		int y;
		double Value=0.0;
		
		for(y=0 ; y<Node ; y++){
			if(y!=i){
				Value+=(V[i][y] - V[y][i]);
			}
		}
		return(Value);
	}
	
	private   double Ali_Mu4_Term(int x, int i)
	{
		return( 1.0 - 2.0*V[x][i] );
	}

	private   double Ali_Mu5_Term(int x, int i, int s, int d)
	{
		return( Kronecker_Delta(x,d)*Kronecker_Delta(i,s) );
	}
	
	private   double Ali_Update_Function(int x, int i, int s, int d, int Node)
	{
		double Value=0.0;

		if(x==d && i==s){
			Value = U[x][i] + DELTA*( -U[x][i]/(double)TAU
	                                  -0.5*ALI_Mu1*Ali_Mu1_Term(x,i,s,d)
	                                  -0.5*ALI_Mu2*Ali_Mu2_Term(x,i,s,d)
	                                  -ALI_Mu3*Ali_Mu3_first_Term(x,Node)
	                                  +ALI_Mu3*Ali_Mu3_second_Term(i,Node)
	                                  -0.5*ALI_Mu4*Ali_Mu4_Term(x,i)
	                                  +0.5*ALI_Mu5*Ali_Mu5_Term(x,i,s,d)

	                                  +0.5*ALI_Mu5
	                                  -0.5*ALI_Mu4 );
		}

	    else{
			Value = U[x][i] + DELTA*( -U[x][i]/(double)TAU
	                                  -0.5*ALI_Mu1*Ali_Mu1_Term(x,i,s,d)
	                                  -0.5*ALI_Mu2*Ali_Mu2_Term(x,i,s,d)
	                                  -ALI_Mu3*Ali_Mu3_first_Term(x,Node)
	                                  +ALI_Mu3*Ali_Mu3_second_Term(i,Node)
	                                  -0.5*ALI_Mu4*Ali_Mu4_Term(x,i)
	                                  +0.5*ALI_Mu5*Ali_Mu5_Term(x,i,s,d)

	                                  -0.5*ALI_Mu1*cost[x][i]
	                                  -0.5*ALI_Mu2*gamma[x][i]
	                                  -0.5*ALI_Mu4 );
		}
		return(Value);
	}
	
	private   void Ali_Hopfield_NN(int s, int d, int Node)
	{
		int x , i;
		
		for(x=0 ; x<Node ; x++){
			for(i=0 ; i<Node ; i++){
				U[x][i]=Ali_Update_Function(x,i,s,d,Node);
				V[x][i]=Sigmoid_Function(U[x][i]);
			}
		}
	}
	
	public  void Ali() 
	{
		// TODO: Add your control notification handler code here
		int ii , jj , Order , Check=-1;
		int Number=0 , Epoch=0 , Count;
		double T_cost=0.0;
		char name[] = new char[200];
		char name1[]= new char[10];

		Loading_Source_Destination(NODE,TNODE);
		Loading_Link_Information(NODE);

		for(Order=0 ; Order<TNODE-1 ; Order++){
			Number=NODE;

			
			Initialize_Value(NODE);

			Epoch=0;

			

			while(SD[Order+1]-1!=Check && Epoch<=20005){

				

				Epoch++;
				Ali_Hopfield_NN(SD[Order]-1 , SD[Order+1]-1 , Number);
				Check=Check_Valid_Path(Order,Number,SD[Order]-1,SD[Order+1]-1);
			}

			
			
			if(Epoch>=20005){
				JOptionPane.showMessageDialog (null,"Ali & Kamoun Algorithm not convergence in this condition");
				System.exit(-1);
			}
			
			
			Count=Path_Count(Order,Number);
			
			
			T_cost+=cost_Value_Save(Order,Count);
		}

		if(Epoch<10000){
			for(jj=0 ; jj<TNODE-1 ; jj++){
				for(ii=0 ; ii<Number ; ii++){
					if(jj==0){
						if(SD_order[jj][ii]!=-10){
							
							JOptionPane.showMessageDialog (null,trimChar(name1)+"" + (SD_order[jj][ii]+1)+ "->");
							
						}
					}
					
					else if(jj==TNODE-1){
						if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]==-10){
							
							JOptionPane.showMessageDialog (null,trimChar(name1) +" " +(SD_order[jj][ii+1]+1)+"->");
							
						}
						else if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]!=-10){
							
							JOptionPane.showMessageDialog (null,trimChar(name1) +" " +(SD_order[jj][ii+1]+1)+"->");
							
						}
					}
				
					else{
						if(SD_order[jj][ii+1]!=-10){
						
							
							JOptionPane.showMessageDialog (null,trimChar(name1)+" "+(SD_order[jj][ii+1]+1)+" ->");
							
						}
						else
							break;
					}			
				}
			}
		}

		
		JOptionPane.showMessageDialog (null,"cost"+(T_cost*10000.0));
		JOptionPane.showMessageDialog (null,"Ali & Kamoun Algorithm finised");


		
	}
                                                                     //-----Park & Choi -----//
        
        
//-----Park & Choi -----//
private  double Park_A_Term(int i, int j)
{
	return( cost[i][j] );
}

//-----Park & Choi ----//
private  double Park_B_Term(int i, int j)
{
	return( (double)gamma[i][j] );
}

//-----Park & Choi  C Term-----//


private  double Park_C_first_Term(int i, int s, int d, int Node)
{
	int k;
	double Sum=0.0;
	
	for(k=0 ; k<Node ; k++){
		if(k!=i)
			Sum+=(V[i][k]-V[k][i]);
	}
	
	return( Sum - PHI_Value(i,s,d) );
}


//-----Park & Choi C Term-----//
private  double Park_C_second_Term(int j, int s, int d, int Node)
{
	int k;
	double Sum=0.0;

	for(k=0 ; k<Node ; k++){
		if(k!=j)
			Sum+=(V[j][k]-V[k][j]);
	}
	return( Sum - PHI_Value(j,s,d) );
}


//-----Park & Choi D Term-----//

private  double Park_D_Term(int i, int j)
{
	return( 1.0- 2.0*V[i][j] );
}

//-----Park & Choi F Term-----//
private double Park_F_Term(int i, int j)
{
	return( (double)gamma[i][j] * V[j][i] );
}

//-----Park & Choi update-----//

private double Park_Update_Function(int i, int j, int s, int d, int Node)
{
	double Value=0.0;
	
	Value = U[i][j] + DELTA*(-U[i][j]/(double)TAU
                            - 0.5*PARK_A*Park_A_Term(i,j)
                            - 0.5*PARK_B*Park_B_Term(i,j)
                            - PARK_C*Park_C_first_Term(i,s,d,Node)
                            + PARK_C*Park_C_second_Term(j,s,d,Node)
                            - 0.5*PARK_D*Park_D_Term(i,j)
                            - 0.5*PARK_F*Park_F_Term(i,j)

                            - 0.5*PARK_A*cost[i][j]
                            - 0.5*PARK_B*(double)gamma[i][j]
                            + PARK_C*PHI_Value(i,s,d)
                            - PARK_C*PHI_Value(j,s,d)
                            - 0.5*PARK_D );
	
	return(Value);
}


//-----Park & Choi  routing path -----//

private void Park_Hopfield_NN(int s, int d, int Node)
{
	int x , i;
	
	for(x=0 ; x<Node ; x++){
		for(i=0 ; i<Node ; i++){
			U[x][i]=Park_Update_Function(x,i,s,d,Node);
			V[x][i]=Sigmoid_Function(U[x][i]);
		}
	}

}
        
        
    //-----Park & Choi  -----//
 public  void Choi(){
     
		int ii, jj, Order, Check=-1;
		int Number=0, Epoch=0, Count;
		double T_cost=0.0;
		char name[]= new char[200];
		char name1[]= new char[10];
		
		Loading_Source_Destination(NODE,TNODE);
		Loading_Link_Information(NODE);
		
		for (Order=0; Order<TNODE-1; Order++){
			Number = NODE;
			Initialize_Value(NODE);
			
			Epoch=0;
			
			while (SD[Order+1]-1!=Check && Epoch<=20005){
				Epoch++;
				Park_Hopfield_NN(SD[Order]-1, SD[Order+1]-1, Number);
				Check=Check_Valid_Path(Order,Number,SD[Order]-1,SD[Order+1]-1);
			}
			
			if (Epoch>=20000){
				JOptionPane.showMessageDialog (null,"No Convergence");
				break;
			}
			
			Count=Path_Count(Order,Number);
			T_cost+=cost_Value_Save(Order,Count);
		}
		
		if(Epoch<10000){
			for(jj=0 ; jj<TNODE-1 ; jj++){
				for(ii=0 ; ii<Number ; ii++){
					if(jj==0){
						if(SD_order[jj][ii]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+"" + (SD_order[jj][ii]+1)+ "->");
							
						}
					}
					
					else if(jj==TNODE-1){
						if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]==-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+""+(SD_order[jj][ii+1]+1));
							
						}
						else if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1) +" " +(SD_order[jj][ii+1]+1)+"->");
							
						}
					}
				
					else{
						if(SD_order[jj][ii+1]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+" "+(SD_order[jj][ii+1]+1)+" ->");
							
						}
						else
							break;
					}			
				}
			}
		}
		
		
		JOptionPane.showMessageDialog (null,"cost"+(T_cost*10000.0));
		JOptionPane.showMessageDialog (null,"Park and Choi - Hopfield Algorithm finised.");
	
	      
	
}    
                                                                //-----Ahn & Ramakrishna -----//
//-----Ahn & Ramakrishna  Mu1 Term-----//
private double Ahn_Mu1_Term(int i, int j)
{
	return( cost[i][j] );
}
//-----Ahn & Ramakrishna  Mu2 Term-----//
private double Ahn_Mu2_Term(int i, int j)
{
	return( (double)gamma[i][j] );
}

//-----Ahn & Ramakrishna  Mu3 Term-----//
private double Ahn_Mu3_first_Term(int i, int s, int d, int Node)
{
	int k;
	double Sum=0.0;
	
	for(k=0 ; k<Node ; k++){
		if(k!=i)
			Sum+=(V[i][k]-V[k][i]);
	}
	
	return( Sum - PHI_Value(i,s,d) );
}


//-----Ahn & Ramakrishna Mu3 Term-----//
private double Ahn_Mu3_second_Term(int j, int s, int d, int Node)
{
	int k;
	double Sum=0.0;
	
	for(k=0 ; k<Node ; k++){
		if(k!=j)
			Sum+=(V[j][k]-V[k][j]);
	}
	
	return( Sum - PHI_Value(j,s,d) );
}


//-----Ahn & Ramakrishna Mu4 Term-----//
private double Ahn_Mu4_Term(int i, int j)
{
	return( 1.0- 2.0*V[i][j] );
}


//-----Ahn & Ramakrishna Mu5 Term-----//
private double Ahn_Mu5_Term(int i, int j, int Node)
{
	return( (double)gamma[i][j] * V[j][i] );
}

//-----Ahn & Ramakrishna  Mu6 Term-----//
private double Ahn_Mu6_Term(int i, int j, int Node)
{
	int k;
	double Sum=0.0;
	
	for(k=0 ; k<Node ; k++){
		if(k!=i && k!=j)
			Sum += (V[i][k]);
	}
	
	Sum-=1.0;
	return( Sum * V[i][j] );
}

//-----Ahn & Ramakrishna  Mu7 Term-----//
private double Ahn_Mu7_Term(int i, int j, int Node)
{
	int k;
	double Sum=0.0;
	
	for(k=0 ; k<Node ; k++){
		if(k!=i && k!=j)
			Sum += (V[k][j]);
	}
	Sum-=1.0;
	
	return( Sum * V[i][j] );
}

//-----Ahn & Ramakrishna update-----//
private double Ahn_Update_Function(int i, int j, int s, int d, int Node)
{
	double Value=0.0;

	Value = U[i][j] + DELTA*(-U[i][j]/(double)TAU
                            - 0.5*Mu1*Ahn_Mu1_Term(i,j)
                            - 0.5*Mu2*Ahn_Mu2_Term(i,j)
                            - Mu3*Ahn_Mu3_first_Term(i,s,d,Node)
                            + Mu3*Ahn_Mu3_second_Term(j,s,d,Node)
                            - 0.5*Mu4*Ahn_Mu4_Term(i,j)
                            - 0.5*Mu5*Ahn_Mu5_Term(i,j,Node)
                            - Mu6*Ahn_Mu6_Term(i,j,Node)
                            - Mu7*Ahn_Mu7_Term(i,j,Node)

                            - 0.5*Mu1*cost[i][j]
                            - 0.5*Mu2*(double)gamma[i][j]
                            + Mu3*PHI_Value(i,s,d)
                            - Mu3*PHI_Value(j,s,d)
                            - 0.5*Mu4 );
	
	return(Value);
}

//-----Ahn & Ramakrishna  routing path -----//
private void Ahn_Hopfield_NN(int s, int d, int Node)
{
	int i , j;
	
	for(i=0 ; i<Node ; i++){
		for(j=0 ; j<Node ; j++){
			U[i][j]=Ahn_Update_Function(i,j,s,d,Node);
			V[i][j]=Sigmoid_Function(U[i][j]);
		}
	}
}

    
  public void Ramakrishna() {
 
     
		int ii, jj, Order, Check=-1;
		int Number=0, Epoch=0, Count;
		double T_cost=0.0;
		char name[]= new char[200];
		char name1[]= new char[10];
		
		Loading_Source_Destination(NODE,TNODE);
		Loading_Link_Information(NODE);
		
		for (Order=0; Order<TNODE-1; Order++){
			Number = NODE;
			Initialize_Value(NODE);
			
			Epoch=0;
			
			while (SD[Order+1]-1!=Check && Epoch<=20005){
				Epoch++;
				Ahn_Hopfield_NN(SD[Order]-1, SD[Order+1]-1, Number);
				Check=Check_Valid_Path(Order,Number,SD[Order]-1,SD[Order+1]-1);
			}
			
			if (Epoch>=10000){
				JOptionPane.showMessageDialog (null,"No Convergence");
				break;
			}
			
			Count=Path_Count(Order,Number);
			T_cost+=cost_Value_Save(Order,Count);
		}
		
		if(Epoch<20000){
			for(jj=0 ; jj<TNODE-1 ; jj++){
				for(ii=0 ; ii<Number ; ii++){
					if(jj==0){
						if(SD_order[jj][ii]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+"" + (SD_order[jj][ii]+1)+ "->");
							
						}
					}
					
					else if(jj==TNODE-1){
						if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]==-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+""+(SD_order[jj][ii+1]+1));
							
						}
						else if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1) +" " +(SD_order[jj][ii+1]+1)+"->");
							
						}
					}
				
					else{
						if(SD_order[jj][ii+1]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1)+" "+(SD_order[jj][ii+1]+1)+" ->");
							
						}
						else
							break;
					}			
				}
			}
		}
		
		
		JOptionPane.showMessageDialog (null,"cost"+(T_cost*10000.0));
		JOptionPane.showMessageDialog (null,"Ahn & Ramakrishna - Hopfield Algorithm finised.");
		
}    
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
        
        
        
        
        
        
        

}
