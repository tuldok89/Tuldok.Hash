#include "pch.h"
#include "HashBase.h"
#include "Blake2b.h"

using namespace CryptoPP;

Tuldok::Hash::Blake2b::Blake2b() : HashBase(new BLAKE2b())
{
    
}

Tuldok::Hash::Blake2b::Blake2b(uint32_t digestSize) : HashBase(new BLAKE2b(digestSize))
{
    
}

