#include "pch.h"
#include "HashBase.h"
#include "Sha3_384.h"

using namespace CryptoPP;

Tuldok::Hash::Sha3_384::Sha3_384() : HashBase(new SHA3_384())
{
    
}
