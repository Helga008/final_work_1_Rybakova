Текстовое описание решения задачи:
1. Создаем метод getIntFromUser, который возвращает значение, введенное пользователем. 
2. Создаем метод GetStringArray: пользователь вводит размер строкового массива, вводит значения с клавиатуры и получает массив.  
3. Создаем метод PrintArray для вывода массива на экран.
4. Создаем метод GetArray3SizeElements, формирующий массив с длиной строк меньше либо равных 3 символам: 
- задаем интовую переменную j=0 и новый массив
- Создаем цикл (int i = 0; i < array.Length; i++) 
- в цикле задаем условие (array[i].Length <=3 - длина элемента массива меньше либо равна 3). При соблюдении условия задаем значение j-го элемента второго массива array2[j] = array[i] и i++ и j++. Если условие не соблюдается - возвращаемся в начало цикла с i++.
- Когда условие (i меньше длины массива array) не соблюдается, выводим массив arr.
5. Задаем переменную length (длина массива), используя метод getIntFromUser. 
6. Создаем массив с помощью метода GetStringArray. Размер = length. Печатаем массив.
7. Задаем новый массив arr с помощью метода GetArray3SizeElements, соответствующий условию задачи. Печатаем.
