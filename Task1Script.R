# TODO: This script allows me to access the data and examine it.  
#        I have found that more males are separated than women.
#        I have also found that the standard deviation of US consituents is 6.466 with a varience of 41.81649
#
# 
# Author: Jonathon Farzanfar
###############################################################################
data <- read.csv("resources\\adult.csv")
names(data)
attributes(data$Never.married)
attributes(data$Male)

MaleData=data$Male
Bachelors=data$Bachelors
US=data$United.States
Married=data$Never.married

df = data.frame(MaleData,Married,Bachelors,US)
MarriedTable=table(Married)

barplot(MarriedTable)#shows types of married and amount in data set

MaleDataTable=table(MaleData,Married)

barplot(MaleDataTable)#shows males and females in the data set

summary(data)

IQR(data$Bachelors)#3

var(table(US)) #41.81649

sd(table(US)) #6.466567

for(i in 1:length(data))
{
	names(data[i])
	length(data[i])
}

#boxplot(data[1:7])



