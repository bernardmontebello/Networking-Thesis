package hnn40;

import javax.swing.JOptionPane;

public class Algs20 {
	
	private final  int TNODE = 2;
	private final  int NODE = 20;
	
	private final  int LAMBDA = 1;
	private final  double DELTA = 0.0001;
	private final  int TAU=1;
	private final  int A=950;
	private final  int B=2500;
	private final  int C=1900;
	private final  int D=100;
	private final  int F=500;
	
	private  int SD[] = new int[TNODE];
	private  int SD_order[][] = new int[TNODE][NODE];
	
	private  double Cost[][] = new double[NODE][NODE];
	private  int Gamma[][]= new int[NODE][NODE];
	
	private  double U[][] = new double[NODE][NODE];
	private  double V[][] = new double[NODE][NODE];
	
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
        
	private String trimChar(char[] temp){
		String result = new String();
		for (int i=0; i<temp.length; i++){
			if (String.valueOf(temp[i])=="") 
				result+=temp[i];
		}
		return result;
	}
	
	private   int Check_Valid_Path(int order, int number, int s, int d)
	{
		int i , j;
		int Visit=-1 , Count=0 , Position=0 , Value=0;

		for(i=0 ; i<number ; i++){
			if(V[s][i]>0.8){
				SD_order[order][0]=s;
				SD_order[order][1]=i;
				Visit=i;
				Position=i;
				Count=3;
			}
		}

		if(d==Visit){
			Value=Visit;
		}
		
		else{
			for(i=0 ; i<number-2 ; i++){
				for(j=0 ; j<number ; j++){
					
					if(V[Position][j]>0.8){
						if(d==j){
							SD_order[order][Count-1]=j;
							Visit=j;
							Value=Visit;
						}
						else{
							SD_order[order][Count-1]=j;
							Count++;
							Position=j;
						}
					}
				}
			}
		}
		
		return(Value);
	}
	
	private   double PHI_Value(int a, int s, int d)
	{
		double Value;

		if(a==s)
			Value=1.0;
		else if(a==d)
			Value=-1.0;
		else
			Value=0.0;
		
		return(Value);
	}
	
	private   double Pro_A_Term(int i, int j, int Node)
	{
		 int k;
		 double Value=0.0;

		 for(k=0 ; k<Node ; k++){
			 if(k!=i)
				 Value += (1.0 - Cost[i][k])*Cost[i][j];
		 }

		 return(Value);
	}
	
	private   double Pro_B_Term(int i, int j)
	{
		return( (double)Gamma[i][j] );

	}

	private   double Pro_C_first_Term(int i, int s, int d, int Node)
	{
		int k;
	    double Sum=0.0;

	    for(k=0 ; k<Node ; k++){
			if(k!=i)
				Sum+=(V[i][k]-V[k][i]);
		}
		return( Sum - PHI_Value(i,s,d) );
	}

	private   double Pro_C_second_Term(int j, int s, int d, int Node)
	{
		int k;
	    double Sum=0.0;

	    for(k=0 ; k<Node ; k++){
			if(k!=j)
				Sum+=(V[j][k]-V[k][j]);
		}
		
		return( Sum - PHI_Value(j,s,d) );
	}

	private   double Pro_D_Term(int i, int j)
	{
		return( 1.0- 2.0*V[i][j] );
	}

	private   double Pro_F_Term(int i, int j, int Node)
	{
		int k;
	    double Value=0.0;

		for(k=0 ; k<Node ; k++){
			Value += (double)Gamma[i][k] * V[k][i];
		}

		return(Value);
	}
	
	private   double Pro_Update_Function(int i, int j, int s, int d, int Node)
	{
		double Value=0.0;
		
		Value = U[i][j] + DELTA*(-U[i][j]/(double)TAU
	                             - 0.5*A*Pro_A_Term(i,j,Node)
	                             - 0.5*B*Pro_B_Term(i,j)
	                             - C*Pro_C_first_Term(i,s,d,Node)
	                             + C*Pro_C_second_Term(j,s,d,Node)
	                             - 0.5*D*Pro_D_Term(i,j)
	                             - 0.5*F*Pro_F_Term(i,j,Node)

	                             - 0.5*A*Cost[i][j]
	                             - 0.5*B*(double)Gamma[i][j]
	                             + C*PHI_Value(i,s,d)
	                             - C*PHI_Value(j,s,d)
	                             - 0.5*D );
		
		return(Value);
	}
	
	private   void Pro_Hopfield_NN (int s, int d, int Node){
		for(int i=0 ; i<Node ; i++){
			for(int j=0 ; j<Node ; j++){
				U[i][j]=Pro_Update_Function(i,j,s,d,Node);
				V[i][j]=Sigmoid_Function(U[i][j]);
			}
		}
	}
	
	private   double Sigmoid_Function(double in){
		return (1/(1+Math.exp(-LAMBDA*in)));
	}
	
	private   void Initialize_Value(int Node){
		for(int i=0 ; i<Node ; i++){
			for(int j=0 ; j<Node ; j++){
				U[i][j]=0.0;
				V[i][j]=Sigmoid_Function(U[i][j]);
			}
		}
	}
	
	private   void Loading_Source_Destination(int Node, int Tnode){
		
	        SD[0]=1;
		SD[1]=20;
		//SD[2]=18;
		//SD[3]=15;
		//SD[4]=5;    
                 
              /*  SD[0]=16;
		SD[1]=5;
		SD[2]=1;
		SD[3]=20;
		SD[4]=17; */
                        
              /*  SD[0]=17;
		SD[1]=19;
		SD[2]=18;
		SD[3]=10;
		SD[4]=3; */
               
             /* SD[0]=4;
		SD[1]=19;
		SD[2]=17;
		SD[3]=6;
		SD[4]=9; */
                
               /* SD[0]=8;
		SD[1]=10;
		SD[2]=20;
		SD[3]=18;
		SD[4]=14;*/
            
              /*  SD[0]=1;
		SD[1]=7;
		SD[2]=18;
		SD[3]=10;
		SD[4]=6; */
             
               /* SD[0]=5;
		SD[1]=13;
		SD[2]=1;
		SD[3]=20;
		SD[4]=17; */
               
            
                /*SD[0]=16;
		SD[1]=5;
		SD[2]=13;
		SD[3]=2;
		SD[4]=20;*/
            
		for (int i=0; i<Tnode; i++){
			for (int j=0; j<Node; j++){
				SD_order[i][j]=-10;
			}
		}
	}
	
	private   void Loading_Link_Information(int Node){
		for (int i=0; i<Node; i++){
			for (int j=0; j<Node; j++){
				Cost[i][j]=-1.0;
				Gamma[i][j]=1;
			}
		}
                
//Cost           

Cost   	[0]	[1]	= 35		;
Cost   	[1]	[0]	= 2		;
Cost   	[0]	[10]	= 4		;
Cost   	[10]	[0]	= 46		;

Cost   	[1]	[2]	= 26 		;
Cost   	[2]	[1]	= 33		;
Cost   	[1]	[7]	= 12 		;
Cost   	[7]	[1]	= 39		;

Cost   	[2]	[3]	= 3 		;
Cost   	[3]	[2]	= 29		;

Cost   	[3]	[4]	= 21 		;
Cost   	[4]	[3]	= 14		;
Cost   	[3]	[6]	= 8		;
Cost   	[6]	[3]	= 13		;
Cost   	[3]	[7]	= 33		;
Cost   	[7]	[3]	= 38		;

Cost   	[4]	[5]	= 32 		;
Cost   	[5]	[4]	= 40		;

Cost   	[5]	[14]	= 32 		;
Cost   	[14]	[5]	= 40		;
Cost   	[5]	[6]	= 32 		;
Cost   	[6]	[5]	= 40		;


Cost   	[6]	[13]	= 13 		;
Cost   	[13]	[6]	= 16		;
Cost   	[6]	[7]	= 46		;
Cost   	[7]	[6]	= 4 		;


Cost   	[7]	[11]	= 49 		;
Cost   	[11]	[7]	= 49		;
Cost   	[8]	[7]	= 28 		;
Cost   	[7]	[8]	= 19		;

Cost   	[8]	[10]	= 25 		;
Cost   	[10]	[8]	= 49		;
Cost   	[9]	[8]	= 28 		;
Cost   	[8]	[9]	= 29		;


Cost   	[9]	[10]	= 37 		;
Cost   	[10]	[9]	= 22		;

Cost   	[10]	[19]	= 16		;
Cost   	[19]	[10]	= 31		;
Cost   	[10]	[11]	= 24 		;
Cost   	[11]	[10]	= 7		;


Cost   	[11]	[18]	= 19		;
Cost   	[18]	[11]	= 32		;
Cost   	[11]	[12]	= 25 		;
Cost   	[12]	[11]	= 21		;

Cost   	[12]	[17]	= 46		;
Cost   	[17]	[12]	= 30		;
Cost   	[12]	[13]	= 16 		;
Cost   	[13]	[12]	= 45		;


Cost   	[13]	[14]	= 39		;
Cost   	[14]	[13]	= 35		;

Cost   	[14]	[15]	= 1		;
Cost   	[15]	[14]	= 28		;
Cost   	[14]	[16]	= 39		;
Cost   	[16]	[14]	= 14		;

Cost   	[19]	[18]	= 33		;
Cost   	[18]	[19]	= 33		;

Cost   	[18]	[17]	= 27		;
Cost   	[17]	[18]	= 34		;

Cost   	[17]	[16]	= 26 		;
Cost   	[16]	[17]	= 23		;

		for(int i=0 ; i<Node ; i++){
			for(int j=0 ; j<Node ; j++){
				if(Cost[i][j]==-1.0){
					Cost[i][j]=1.0;
					Gamma[i][j]=1;
				}
				else{
					Cost[i][j]/=10000.0;
					Gamma[i][j]=0;
				}
			}
		}

		//for(int i=0 ; i<Node ; i++){
		//	for(int j=0 ; j<Node ; j++){
					//Cost[j][i]=Cost[i][j];
					//Gamma[j][i]=Gamma[i][j];
					//JOptionPane.showMessageDialog (null,Cost[i][j]);
			//}
		//}
		
		
	}
	
	private  int Path_Count(int order, int number)
	{
		int i , count=0;
		
		for(i=0 ; i<number ; i++){
			if(SD_order[order][i]!=-10)
				count++;
		}
		return(count);
	}
	
	private   double Cost_Value_Save(int order, int count)
	{
		int i;
		double Cost_Sum=0.0;

		for(i=0 ; i<count-1 ; i++){
			Cost_Sum+=Cost[SD_order[order][i]][SD_order[order][i+1]];
		}
		return(Cost_Sum);
	}
	
	public  void Pro(){
		int ii, jj, Order, Check=-1;
		int Number=0, Epoch=0, Count;
		double T_Cost=0.0;
		char name[]= new char[200];
		char name1[]= new char[10];
		
		Loading_Source_Destination(NODE,TNODE);
		Loading_Link_Information(NODE);
		
		for (Order=0; Order<TNODE-1; Order++){
			Number = NODE;
			Initialize_Value(NODE);
			
			Epoch=0;
			
			while (SD[Order+1]-1!=Check && Epoch<=10005){
				Epoch++;
				Pro_Hopfield_NN(SD[Order]-1, SD[Order+1]-1, Number);
				Check=Check_Valid_Path(Order,Number,SD[Order]-1,SD[Order+1]-1);
			}
			
			if (Epoch>=10000){
				JOptionPane.showMessageDialog (null,"Park And  Keum Hopfield Neural Netork Algorithm did not Converge");
				break;
			}
			
			Count=Path_Count(Order,Number);
			T_Cost+=Cost_Value_Save(Order,Count);
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
		
		System.out.println();
		JOptionPane.showMessageDialog (null,"Cost"+(T_Cost*10000.0));
		JOptionPane.showMessageDialog (null,"Park And  Keum Hopfield Neural Netork Algorithm finised.");

		
		
	}
	
	private   double Kronecker_Delta(int i, int j)
	{
		 return( (i==j)?1:0 );
	}
	
	private   double Ali_Mu1_Term(int x, int i, int s, int d)
	{
		return( Cost[x][i] * (1.0 - Kronecker_Delta(x,d)*Kronecker_Delta(i,s)) );
	}

	private   double Ali_Mu2_Term(int x, int i, int s, int d)
	{
		return( (double)Gamma[x][i] * (1.0 - Kronecker_Delta(x,d)*Kronecker_Delta(i,s)) );
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

	                                  -0.5*ALI_Mu1*Cost[x][i]
	                                  -0.5*ALI_Mu2*Gamma[x][i]
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
		double T_Cost=0.0;
		char name[] = new char[200];
		char name1[]= new char[10];

		Loading_Source_Destination(NODE,TNODE);
		Loading_Link_Information(NODE);

		for(Order=0 ; Order<TNODE-1 ; Order++){
			Number=NODE;

			
			Initialize_Value(NODE);

			Epoch=0;

			

			while(SD[Order+1]-1!=Check && Epoch<=10005){

				

				Epoch++;
				Ali_Hopfield_NN(SD[Order]-1 , SD[Order+1]-1 , Number);
				Check=Check_Valid_Path(Order,Number,SD[Order]-1,SD[Order+1]-1);
			}

			
			
			if(Epoch>=10000){
				JOptionPane.showMessageDialog (null,"Ali & Kamoun Algorithm not convergence in this condition");
				System.exit(-1);
			}
			
			
			Count=Path_Count(Order,Number);
			
			
			T_Cost+=Cost_Value_Save(Order,Count);
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

		System.out.println();
		JOptionPane.showMessageDialog (null,"Cost"+(T_Cost*10000.0));
		JOptionPane.showMessageDialog (null,"Ali & Kamoun Algorithm finised");
               

		
	}
                                                                     //-----Park & Choi -----//
        
        
//-----Park & Choi -----//
private  double Park_A_Term(int i, int j)
{
	return( Cost[i][j] );
}

//-----Park & Choi ----//
private  double Park_B_Term(int i, int j)
{
	return( (double)Gamma[i][j] );
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
	return( (double)Gamma[i][j] * V[j][i] );
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

                            - 0.5*PARK_A*Cost[i][j]
                            - 0.5*PARK_B*(double)Gamma[i][j]
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
		double T_Cost=0.0;
		char name[]= new char[200];
		char name1[]= new char[10];
		
		Loading_Source_Destination(NODE,TNODE);
		Loading_Link_Information(NODE);
		
		for (Order=0; Order<TNODE-1; Order++){
			Number = NODE;
			Initialize_Value(NODE);
			
			Epoch=0;
			
			while (SD[Order+1]-1!=Check && Epoch<=10005){
				Epoch++;
				Park_Hopfield_NN(SD[Order]-1, SD[Order+1]-1, Number);
				Check=Check_Valid_Path(Order,Number,SD[Order]-1,SD[Order+1]-1);
			}
			
			if (Epoch>=10000){
				JOptionPane.showMessageDialog (null,"No Convergence");
				break;
			}
			
			Count=Path_Count(Order,Number);
			T_Cost+=Cost_Value_Save(Order,Count);
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
		
		System.out.println();
		JOptionPane.showMessageDialog (null,"Cost"+(T_Cost*10000.0));
		JOptionPane.showMessageDialog (null,"Park and Choi - Hopfield Algorithm finised.");
	
	      
	
}    
                                                                //-----Ahn & Ramakrishna -----//
//-----Ahn & Ramakrishna  Mu1 Term-----//
private double Ahn_Mu1_Term(int i, int j)
{
	return( Cost[i][j] );
}
//-----Ahn & Ramakrishna  Mu2 Term-----//
private double Ahn_Mu2_Term(int i, int j)
{
	return( (double)Gamma[i][j] );
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
	return( (double)Gamma[i][j] * V[j][i] );
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

                            - 0.5*Mu1*Cost[i][j]
                            - 0.5*Mu2*(double)Gamma[i][j]
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
		double T_Cost=0.0;
		char name[]= new char[200];
		char name1[]= new char[10];
		
		Loading_Source_Destination(NODE,TNODE);
		Loading_Link_Information(NODE);
		
		for (Order=0; Order<TNODE-1; Order++){
			Number = NODE;
			Initialize_Value(NODE);
			
			Epoch=0;
			
			while (SD[Order+1]-1!=Check && Epoch<=10005){
				Epoch++;
				Ahn_Hopfield_NN(SD[Order]-1, SD[Order+1]-1, Number);
				Check=Check_Valid_Path(Order,Number,SD[Order]-1,SD[Order+1]-1);
			}
			
			if (Epoch>=10000){
				JOptionPane.showMessageDialog (null,"No Convergence");
				break;
			}
			
			Count=Path_Count(Order,Number);
			T_Cost+=Cost_Value_Save(Order,Count);
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
							JOptionPane.showMessageDialog (null,trimChar(name1)+""+(SD_order[jj][ii+1]+1)+ "->");
							
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
		JOptionPane.showMessageDialog (null, "Cost"+(T_Cost*10000.0));
		JOptionPane.showMessageDialog (null,"Ahn & Ramakrishna - Hopfield Algorithm finised.");
		
}    
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
        
        
        
        
        
        
        

}
