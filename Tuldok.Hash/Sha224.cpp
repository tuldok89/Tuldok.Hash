#include "pch.h"
#include "HashBase.h"
#include "Sha224.h"

using namespace CryptoPP;

Tuldok::Hash::Sha224::Sha224() : HashBase(new SHA224())
{
}
