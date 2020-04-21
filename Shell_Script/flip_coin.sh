#! /bin/bash

echo "enter number of times to flip"
read number

head=0
tail=0
num=5
for (( i=0; i<$number; i++ ))
do
if [ $(( $RANDOM % 10 )) -gt 5 ]
then
((head = head + 1))
else
((tail = tail + 1))
fi
done

headPercent=`expr (head \* 100) / $number`
echo "$headPercent"
echo "$tail"