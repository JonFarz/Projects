# TODO: Add comment
# 
# Author: Jonny
###############################################################################


data2 <- read.csv("resources\\imports-85.data")
summary(data2)
#attributes(data2)

x <- scale(as.numeric(data2$X3))
princomp(x)


scale(data2$X48.80)

factor(data2$gas)

factor(data2$rwd)
kmeans(sort.list(data2$two),3)

kmeans(sort.list(data2$gas),2)

