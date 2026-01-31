import 'dart:io';

void main() {
  int n = int.parse(stdin.readLineSync()!);

  for (int i = 0; i < n; i++) {
    int x = int.parse(stdin.readLineSync()!);

    if (x == 0) {
      print("NULL");
    } else {
      String result = '';

      if (x % 2 == 0) {
        result += 'EVEN ';
      } else {
        result += 'ODD ';
      }

      if (x > 0) {
        result += 'POSITIVE';
      } else {
        result += 'NEGATIVE';
      }

      print(result);
    }
  }
}
