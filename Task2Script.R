# TODO: Add comment
# 
# Author: Jonathon Farzanfar
###############################################################################


data <- read.csv("resources\\house-votes-84.csv")
#summary(data)

#ncol(data)
#nrow(data)
#names(data)
#attributes(data$republican)

DemoRepubMatrix=matrix(data$republican, byrow=T)
dimnames(DemoRepubMatrix) <- list(NULL,"Party")


mati=DemoRepubMatrix

for(i in 2:length(data))
{
	name = names(data[i]) #get column name
	x = c(data[,i])-1 #remove 1 for binary representation
	x = as.integer(x<2) #bring anything inside of the rage 0 and 1 (Yes and No) NOT ?
	m = matrix(x) #create a matrix of the data
	dimnames(m) <- list(NULL, name) #name the column of the matrix its column name
	mati <- cbind(mati, m) #append column to new matrix
}

#instanciate republican and democrate matrixs
matiRepub <- as.matrix(mati[0,2:ncol(mati)])
matiDemo <- as.matrix(mati[0,2:ncol(mati)])

#fill matrix with associated data
for(p in 1:nrow(data))
{
	vmatrix = as.matrix(mati[p,2:ncol(mati)])
	vmatrix = matrix(vmatrix,ncol = 16)
	vmatrix
	if(mati[p]=="republican")
	{	
		matiRepub <- rbind(matiRepub,vmatrix)	
	}
	if(mati[p]=="democrat")
	{
		matiDemo <- rbind(matiDemo,vmatrix)
	}
}



matiRepub
nrow(matiRepub) #167

matiDemo
nrow(matiDemo) #267 

#More Democrates Votes either yes or no across 16 bills than republicans by 100 (Removed any data associated with NAs : ?)

calculateDistanceReturnMatrix <- function(pMatrix)
{
	
}