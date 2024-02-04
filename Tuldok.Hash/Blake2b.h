#pragma once
class HashBase;

namespace Tuldok
{
	namespace Hash
	{
		public ref class Blake2b : HashBase
		{
		public:
			Blake2b();
			Blake2b(uint32_t digestSize);
		};
	}
}

