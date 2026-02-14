import 'dart:io';

void main() {
  int evenCount = 0;
  int oddCount = 0;
  int positiveCount = 0;
  int negativeCount = 0;

  for (int i = 0; i < 5; i++) {
    int number = int.parse(stdin.readLineSync()!);

    if (number % 2 == 0) {
      evenCount++;
    } else {
      oddCount++;
    }

    if (number > 0) {
      positiveCount++;
    } else if (number < 0) {
      negativeCount++;
    }
  }

  print('$evenCount valor(es) par(es)');
  print('$oddCount valor(es) impar(es)');
  print('$positiveCount valor(es) positivo(s)');
  print('$negativeCount valor(es) negativo(s)');
}
