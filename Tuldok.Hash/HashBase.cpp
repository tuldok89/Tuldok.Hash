#include "pch.h"
#include "HashBase.h"

using namespace CryptoPP;

void Tuldok::Hash::HashBase::HashCore(array<unsigned char, 1>^ array, int ibStart, int cbSize)
{
    pin_ptr<unsigned char> pp = &array[0];
    _hasher->Update(pp + ibStart, cbSize);
}

array<unsigned char, 1>^ Tuldok::Hash::HashBase::HashFinal()
{
    auto arr = gcnew array<unsigned char>(_hasher->DigestSize());
    pin_ptr<unsigned char> pp = &arr[0];
    _hasher->Final(pp);
    return arr;
}

Tuldok::Hash::HashBase::!HashBase()
{
    delete _hasher;
}

Tuldok::Hash::HashBase::HashBase(CryptoPP::HashTransformation* hasher) : _hasher(hasher)
{
}

void Tuldok::Hash::HashBase::Initialize()
{
    _hasher->Restart();
}

Tuldok::Hash::HashBase::~HashBase()
{
    this->!HashBase();
}

int Tuldok::Hash::HashBase::HashSize::get()
{
    return _hasher->DigestSize() * 8;
}
