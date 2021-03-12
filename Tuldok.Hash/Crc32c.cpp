#include "pch.h"
#include "HashBase.h"
#include "Crc32c.h"

using namespace CryptoPP;

Tuldok::Hash::Crc32c::Crc32c() : HashBase(new CRC32C())
{
		
}
