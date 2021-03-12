#include "pch.h"
#include "HashBase.h"
#include "Sha3_224.h"

using namespace CryptoPP;

Tuldok::Hash::Sha3_224::Sha3_224() : HashBase(new SHA3_224())
{
}
