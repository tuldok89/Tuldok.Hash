#include "pch.h"
#include "HashBase.h"
#include "Keccak_512.h"

Tuldok::Hash::Keccak_512::Keccak_512() : HashBase(new CryptoPP::Keccak_512())
{
    
}
