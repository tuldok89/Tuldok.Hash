#include "pch.h"
#include "HashBase.h"
#include "Blake2s.h"

using namespace CryptoPP;

Tuldok::Hash::Blake2s::Blake2s() : HashBase(new BLAKE2s())
{

}

Tuldok::Hash::Blake2s::Blake2s(uint32_t digestSize) : HashBase(new BLAKE2s(digestSize))
{

}
