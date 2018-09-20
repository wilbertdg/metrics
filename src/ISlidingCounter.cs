
namespace Metrics {

	using System;

	public interface ISlidingCounter {
		void Add(long value);
		long Value { get; }
	}
}
