
$i = 0
$numArray = []

while $i < 10
  puts "Digite um numero da posicao #{$i}:"
  num = gets.chomp.to_i

  if $i == 0
    $numArray.insert($i,num)
    $i+=1
  else
    if $numArray.include?(num) == false
     $numArray.insert($i, num)
      $i+=1
    end
end
end

print $numArray.take(10)

max = $numArray.take(10).max

puts "\nMaior: #{max}"

if $numArray.first != max
  $secMax = $numArray[0]
else
  $secMax = $numArray[1]
end

$numArray.each do |num|
   if num != max and $secMax < num
      $secMax = num
  end
end

puts "Segundo Maior: #{$secMax}"











