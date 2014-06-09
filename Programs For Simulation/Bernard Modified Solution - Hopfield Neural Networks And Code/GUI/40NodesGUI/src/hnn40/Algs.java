package hnn40;

import javax.swing.JOptionPane;

public class Algs {
	
	private final int TNODE = 5; //number of nodes to reach destination
	private final int NODE = 40; //number of nodes in total
	
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
                SD[1]=35;
                SD[2]=34;
                SD[3]=8;
                SD[4]=18;
                
                
                
                
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
		
		//set costs between all nodes
		
		cost[0][1]=840;
		cost[1][0]=713;   
		cost[0][6]=67;
		cost[6][0]=893;        
		cost[0][5]=690;
		cost[5][0]=463;        
		cost[0][4]=607;
		cost[4][0]=694; 
		       
		cost[1][2]=3;
		cost[2][1]=139;        
		cost[1][6]=814;
		cost[6][1]=606;

		        
		cost[6][2]=632;
		cost[2][6]=279;        
		cost[6][9]=299;
		cost[9][6]=800;
		        
		cost[5][9]=584;
		cost[9][5]=565;        
		cost[5][12]=954;
		cost[12][5]=433;        
		cost[5][13]=901;
		cost[13][5]=566;

		        
		cost[4][13]=731;
		cost[13][4]=515;
		        
		cost[13][18]=814;
		cost[18][13]=981;        
		cost[13][19]=688;
		cost[19][13]=91;
		        
		cost[9][7]=950;
		cost[7][9]=599;        
		cost[9][11]=143;
		cost[11][9]=952;        
		cost[9][16]=84;
		cost[16][9]=83;        
		cost[9][12]=871;
		cost[12][9]=214;

		        
		cost[12][17]=275;
		cost[17][12]=192;

		cost[2][3]=783;
		cost[3][2]=708;   
		cost[2][7]=724;
		cost[7][2]=911;

		        
		cost[3][8]=396;
		cost[8][3]=582;
		        
		cost[8][7]=816;
		cost[7][8]=182;        
		cost[8][11]=352;
		cost[11][8]=755;        
		cost[8][10]=412;
		cost[10][8]=386;
		        
		cost[7][11]=442;
		cost[11][7]=184;
		        
		cost[11][10]=907;
		cost[10][11]=666;        
		cost[11][15]=834;
		cost[15][11]=440;        
		cost[11][16]=21;
		cost[16][11]=615;
		        
		cost[10][14]=83;
		cost[14][10]=265;
		        
		cost[14][15]=940;
		cost[15][14]=764;        
		cost[14][24]=441;
		cost[24][14]=206;        
		cost[14][25]=31;
		cost[25][14]=576;        
		cost[14][23]=875;
		cost[23][14]=598;

		cost[15][24]=708;
		cost[24][15]=204; 
		       
		cost[24][16]=249;
		cost[16][24]=183;        
		cost[24][22]=545;
		cost[22][24]=29;
		        
		cost[16][17]=602;
		cost[17][16]=976;  
		     
		cost[18][17]=542;
		cost[17][18]=969;   
		cost[18][19]=212;
		cost[19][18]=40; 
		       
		cost[19][21]=237;
		cost[21][19]=356;        
		cost[19][20]=117;
		cost[20][19]=343;
		        
		cost[21][17]=628;
		cost[17][21]=12;        
		cost[21][20]=357;
		cost[20][21]=276; 
		 
		cost[17][22]=800;
		cost[22][17]=801;        
		cost[17][28]=284;
		cost[28][17]=134; 
		      
		cost[20][31]=257;
		cost[31][20]=934;        
		cost[20][34]=489;
		cost[34][20]=362; 
		       
		cost[28][27]=409;
		cost[27][28]=455;        
		cost[28][31]=183;
		cost[31][28]=774;  
		      
		cost[22][26]=882;
		cost[26][22]=181;
		        
		cost[27][26]=895;
		cost[26][27]=800; 
		       
		cost[26][25]=514;
		cost[25][26]=516;        
		cost[26][29]=597;
		cost[29][26]=197;        
		cost[26][33]=925;
		cost[33][26]=735;        
		cost[26][30]=570;
		cost[30][26]=879;
		        
		cost[23][25]=693;
		cost[25][23]=928;            
		cost[23][29]=805;
		cost[29][23]=735;        
		cost[23][32]=619;
		cost[32][23]=211; 
		       
		cost[37][32]=197;
		cost[32][37]=740;        
		cost[37][29]=487;
		cost[29][37]=267;        
		cost[37][33]=725;
		cost[33][37]=891;        
		cost[37][36]=479;
		cost[36][37]=266;       
		cost[37][39]=406;
		cost[39][37]=616;

		cost[33][30]=666;
		cost[30][33]=942;  
		      
		cost[30][36]=107;
		cost[36][30]=840;        
		cost[30][35]=416;
		cost[35][30]=499;        
		cost[30][31]=687;
		cost[31][30]=76;   
		     
		cost[34][31]=345;
		cost[31][34]=644;          
		cost[34][35]=726;
		cost[35][34]=493;        
		cost[34][38]=360;
		cost[38][34]=926;
		        
		cost[36][35]=491;
		cost[35][36]=465;        
		cost[36][39]=168;
		cost[39][36]=489;        
		cost[36][38]=6;
		cost[38][36]=968;
		        
		cost[38][39]=809;
		cost[39][38]=29; 
		
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
				  JOptionPane.showMessageDialog (null,"Park And  Keum Hopfield Neural Netork Algorithm  did not Converge");
                                			
                                  for(jj=0 ; jj<TNODE-1 ; jj++){
                                                            
                                                            
				for(ii=0 ; ii<number ; ii++){
					if(jj==0){
						if(SD_order[jj][ii]!=-10){
							JOptionPane.showMessageDialog (null,((SD_order[jj][ii]+1)+ "->"));
							
						}
					}
					
					else if(jj==TNODE-1){
						if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]==-10){
							JOptionPane.showMessageDialog (null,(SD_order[jj][ii+1]+1));
							
						}
						else if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]!=-10){
							JOptionPane.showMessageDialog (null,(SD_order[jj][ii+1]+1)+"->");
							
						}
					}
				
					else{
						if(SD_order[jj][ii+1]!=-10){
							JOptionPane.showMessageDialog (null,(SD_order[jj][ii+1]+1)+" ->");
							
						}
						else
							break;
					}			
				}
			}
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
							JOptionPane.showMessageDialog (null, (SD_order[jj][ii]+1)+ "->");
							
						}
					}
					
					else if(jj==TNODE-1){
						if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]==-10){
							JOptionPane.showMessageDialog (null,""+(SD_order[jj][ii+1]+1));
							
						}
						else if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]!=-10){
							JOptionPane.showMessageDialog (null,(SD_order[jj][ii+1]+1)+"->");
							
						}
					}
				
					else{
						if(SD_order[jj][ii+1]!=-10){
							JOptionPane.showMessageDialog (null,(SD_order[jj][ii+1]+1)+" ->");
							
						}
						else
							break;
                                                
					}
                                        
                                      
				}
                          
			}
		}
	     
		System.out.println();
                JOptionPane.showMessageDialog (null, "Cost"+(t_cost*10000.0));
                System.out.println("Cost:" + t_cost*10000.0);
		System.out.println("Park And  Keum Hopfield Neural Netork Algorithmfinised.");
		
		
		
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
				JOptionPane.showMessageDialog (null, "Ali & Kamoun Algorithm not convergence in this condition");
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
							
							JOptionPane.showMessageDialog (null, trimChar(name1)+"" + (SD_order[jj][ii]+1)+ "->");
							
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

		System.out.println();
		JOptionPane.showMessageDialog (null, "cost" +(T_cost*10000.0));
		JOptionPane.showMessageDialog (null, "Ali & Kamoun Algorithm finised");


		
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
				JOptionPane.showMessageDialog (null, "Park and Choi - Hopfield Algorithm did not Converge");
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
							JOptionPane.showMessageDialog (null, trimChar(name1)+"" + (SD_order[jj][ii]+1)+ "->");
							
						}
					}
					
					else if(jj==TNODE-1){
						if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]==-10){
							JOptionPane.showMessageDialog (null, trimChar(name1)+""+(SD_order[jj][ii+1]+1));
						
						}
						else if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]!=-10){
							JOptionPane.showMessageDialog (null, trimChar(name1) +" " +(SD_order[jj][ii+1]+1)+"->");
							
						}
					}
				
					else{
						if(SD_order[jj][ii+1]!=-10){
							JOptionPane.showMessageDialog (null, trimChar(name1)+" "+(SD_order[jj][ii+1]+1)+" ->");
							
						}
						else
							break;
					}			
				}
			}
		}
		
		System.out.println();
		JOptionPane.showMessageDialog (null,"Cost"+(T_cost*10000.0));
		JOptionPane.showMessageDialog (null, "Park and Choi - Hopfield Algorithm finised.");
	
	      
	
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
				JOptionPane.showMessageDialog (null,"Ahn & Ramakrishna - Hopfield Algorithm dit not Converge");
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
							JOptionPane.showMessageDialog (null, trimChar(name1)+"" + (SD_order[jj][ii]+1)+ "->");
							
						}
					}
					
					else if(jj==TNODE-1){
						if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]==-10){
							JOptionPane.showMessageDialog (null, trimChar(name1)+""+(SD_order[jj][ii+1]+1));
							
						}
						else if(SD_order[jj][ii+1]!=-10 && SD_order[jj][ii+2]!=-10){
							JOptionPane.showMessageDialog (null,trimChar(name1) +" " +(SD_order[jj][ii+1]+1)+"->");
							
						}
					}
				
					else{
						if(SD_order[jj][ii+1]!=-10){
							JOptionPane.showMessageDialog (null, trimChar(name1)+" "+(SD_order[jj][ii+1]+1)+" ->");
							
						}
						else
							break;
					}			
				}
			}
		}
		
		System.out.println();
		JOptionPane.showMessageDialog (null, "Cost"+(T_cost*10000.0));
		JOptionPane.showMessageDialog (null, "Ahn & Ramakrishna - Hopfield Algorithm finised.");
		
}    


 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
        
        
        
        
        
        
        

}
