#include "pch.h"
#include "HashBase.h"
#include "Keccak_224.h"

Tuldok::Hash::Keccak_224::Keccak_224() : HashBase(new CryptoPP::Keccak_224())
{
    
}
