#include <iostream>

using namespace std; 

class A
{
public:
    void f()
    {
        cout << "A";
    }
};

class B : public virtual A
{
public:
    void f()
    {
        cout << "B";
    }
};

class C : public virtual A
{
public:
    void f()
    {
        cout << "C";
    }
};

class D : public virtual A, public virtual B//, public virtual E
{
public:
    void f()
    {
        cout << "D";
    }
};

class E : public C, public D
{
public:
    void f()
    {
        cout << "E";
    }
};

class F : public D, public E 
{
public:
    void f()
    {
        cout << "F";
    }
};

int main()
{
    F objic1;
    objic1.f();

    return 0;
}

