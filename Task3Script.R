# TODO: Add comment
# 
# Author: Jonny
###############################################################################

data2 <- read.csv("resources\\imports-85.data")
#summary(data2)
#attributes(data2)

#x <- scale(as.numeric(data2$X3))
#princomp(x)

for(i in names(data2))
{
	repi <- noquote(paste("data2$",i, sep=""))
	print(repi)
	xi <- scale(as.numeric(repi))
	princomp(xi)
}
