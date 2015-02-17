# TODO: Add comment
# 
# Author: Jonathon Farzanfar
###############################################################################


data <- read.csv("resources\\house-votes-84.csv")
summary(data)

#ncol(data)
#nrow(data)
#names(data)
#attributes(data$republican)


DemoRepubMatrix=matrix(data$republican, byrow=T)
dimnames(DemoRepubMatrix) <- list(NULL,"Party")

N_Matrix = matrix(c(data[2]))

dimnames(N_Matrix) <- list(NULL,"N")

#DemoRepubMatrix
names(data[2])
length(data)

mati=DemoRepubMatrix

for(i in 2:length(data))
{
	name = names(data[i]) #get column name
	x = c(data[,i])-1 #remove 1 for binary representation
	x = as.integer(x<2) #bring anything inside of the rage 0 and 1 (Yes and No) NOT ?
	#m = matrix(as.integer(c(data[,i])-1)<2)
	m = matrix(x) #create a matrix of the data
	dimnames(m) <- list(NULL, name) #name the column of the matrix its column name
	mati <- cbind(mati, m) #append column to new matrix
}
#mati <- cbind(DemoRepubMatrix, N_Matrix)

mati
#y = c(data[,2])-1
#y = as.integer(y<2)
#y



#DemoRepubMatrix

