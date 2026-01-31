import 'dart:io';

void main() {
  int positiveCount = 0;

  for (int i = 0; i < 6; i++) {
    double number = double.parse(stdin.readLineSync()!);

    if (number > 0) {
      positiveCount++;
    }
  }

  print('$positiveCount valores positivos');
}
