# WPF_Infrostruktura_TK_test_task
#Задача: поиск переменных в группах переменных и вывод в MessageBox переменых для отправки с приминением MVVM паттерна проектирования.
Пример входных данных:
Группа - Растение
Переменная - Фикус
Описание - Фи́кус (лат. Ficus) — род растений семейства Тутовые (Moraceae), в составе которого образует монотипную трибу Фикусовые (Ficeae). Большинство видов — вечнозелёные, некоторые — листопадные.
# Объем данных на которых тестировался поиск
Кол-во групп - 120шт.
Переменных в каждой группе - 1000шт.
Кол-во символов у группы - 30 шт.
Кол-во символов у переменной 30 шт.
Кол-во символов в описании - 3000 шт.
#Худший случай 
Когда мы ищем 1 символ в описании, которого нет ни в одной записи
Время вычисления - 3.5 секунды (ЦП -i7 2.49Гц при минимальной загрузки системы посторонними программами).

