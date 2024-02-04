#include "pch.h"
#include "HashBase.h"
#include "Keccak_384.h"

Tuldok::Hash::Keccak_384::Keccak_384() : HashBase(new CryptoPP::Keccak_384())
{
    
}
