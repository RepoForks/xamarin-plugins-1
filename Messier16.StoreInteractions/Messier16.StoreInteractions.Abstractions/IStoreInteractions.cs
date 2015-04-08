using System;

namespace Messier16.StoreInteractions.Abstractions
{
	public interface IStoreInteractions
	{
		bool OpenForPublisher (string publisherName);
		bool OpenForApp (string app);
		bool OpenForQuery (string query);
	}
}

