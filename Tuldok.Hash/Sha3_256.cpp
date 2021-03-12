#include "pch.h"
#include "HashBase.h"
#include "Sha3_256.h"

using namespace CryptoPP;

Tuldok::Hash::Sha3_256::Sha3_256() : HashBase(new SHA3_256())
{

}
