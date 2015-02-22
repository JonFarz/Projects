# TODO: Add comment
# 
# Author: Jonny
###############################################################################



data2 <- read.csv("resources\\imports-85.data")
summary(data2)
attributes(data2)

princomp(data2, cor = TRUE)