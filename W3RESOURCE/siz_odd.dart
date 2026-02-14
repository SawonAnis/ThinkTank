import 'dart:io';

void main() {
  int value = int.parse(stdin.readLineSync()!);

  if (value % 2 == 0) {
    value++;
  }

  for (int i = 0; i < 6; i++) {
    print(value);
    value += 2;
  }
}