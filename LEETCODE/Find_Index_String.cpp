#include<iostream>
#include<string>
using namespace std;

int main(){
  string a1, a2;
  cin >> a1 >> a2;

  if(a1.find(a2) != string::npos){
    cout << a1.find(a2) << endl;
  } else {
    cout << -1 << endl;
  }
}