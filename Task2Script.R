# TODO: Add comment
# 
# Author: Jonathon Farzanfar
###############################################################################

#FUNCTIONS

convertDataToMatrix <- function(df)
{
	nColData <- ncol(df)
	namesdf <- names(df)
	dataMatrix <- as.matrix(df,ncol=nColData,dimnames = namesdf)
	colnames(dataMatrix)[1] <- "Party"
	dataMatrix[dataMatrix %in% "?"] <- as.numeric(0)
	dataMatrix[dataMatrix %in% "n"] <- as.numeric(0)
	dataMatrix[dataMatrix %in% "y"] <- as.numeric(1)
	return (dataMatrix)
}

subsetDataToMatrix <- function(mat, textToLimitBy)
{
	x <- subset(mat,mat[,1]==textToLimitBy,1:ncol(mat))
	return(x)
}


createContingencyTableFromMatrix <- function(pMatrix)
{
	mxp <- colnames(pMatrix)
	yesBinary <- colSums(pMatrix<1)
	noBinary <- colSums(pMatrix==1)
	mxp <- rbind(mxp,as.integer(yesBinary))
	mxp <- rbind(mxp,as.integer(noBinary))
	mxp <- mxp[2:3,]
	rownames(mxp) <- c('yes','no')
	colnames(mxp) <- colnames(pMatrix)
	return(mxp)
}

distancefinder <- function(p)
{
	mxp <- matrix(colnames(p), nrow=1, ncol=16)
	colnames(mxp) <- colnames(p)
	#mxp <- as.matrix(mxp, ncol=16, nrow=0)
	#print(mxp)
	for(i in 1:ncol(p))
	{
		mxp[1,i] = abs(diff(as.numeric(p[,i])))
	}
	rownames(mxp) <- "Difference"
	return(mxp)
}

#END FUNCTIONS

data <- read.csv("resources\\house-votes-84.csv") #Read file dataset

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
	as.integer(vmatrix)
	if(mati[p]=="republican")
	{	
		matiRepub <- rbind(matiRepub,as.integer(vmatrix))	
	}
	if(mati[p]=="democrat")
	{
		matiDemo <- rbind(matiDemo,as.integer(vmatrix))
	}
}


#matiRepub
nrow(matiRepub) #167

#matiDemo
nrow(matiDemo) #267 

#matiDemo


#More Democrates Votes either yes or no across 16 bills than republicans by 100 (Removed any data associated with NAs : ?)

matiDemoContig <- createContingencyTableFromMatrix(matiDemo)
matiRepubContig <- createContingencyTableFromMatrix(matiRepub)
#matiContig <- createContingencyTableFromMatrix(mati)

#distancefinder(matiContig)
#matiDemoContig
distancefinder(matiDemoContig)
#matiRepubContig
distancefinder(matiRepubContig)
