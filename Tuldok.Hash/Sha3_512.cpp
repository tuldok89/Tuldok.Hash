#include "pch.h"
#include "HashBase.h"
#include "Sha3_512.h"

using namespace CryptoPP;

Tuldok::Hash::Sha3_512::Sha3_512() : HashBase(new SHA3_512())
{
}
