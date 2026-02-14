import 'dart:io';

void main() {
  int evenCount = 0;

  for (int i = 0; i < 5; i++) {
    int number = int.parse(stdin.readLineSync()!);

    if (number % 2 == 0) {
      evenCount++;
    }
  }

  print('$evenCount valores pares');
}
