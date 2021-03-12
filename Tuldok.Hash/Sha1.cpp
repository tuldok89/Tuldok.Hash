#include "pch.h"
#include "HashBase.h"
#include "Sha1.h"

using namespace CryptoPP;

Tuldok::Hash::Sha1::Sha1() : HashBase(new SHA1())
{
}
