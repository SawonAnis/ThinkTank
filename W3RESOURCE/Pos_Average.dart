import 'dart:io';

void main() {
  int positiveCount = 0;
  double sum = 0.0;

  for (int i = 0; i < 6; i++) {
    double number = double.parse(stdin.readLineSync()!);

    if (number > 0) {
      positiveCount++;
      sum += number;
    }
  }

  double average = sum / positiveCount;

  print('$positiveCount valores positivos');
  print(average.toStringAsFixed(1));
}
