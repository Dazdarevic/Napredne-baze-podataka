﻿using MediatR;

namespace Napredne_baze_podataka_API.Commands.Member_Commands
{
    public class ChooseTrainerCommand : IRequest<bool>
    {
        public int MemberId { get; }
        public int TrainerId { get; }

        public ChooseTrainerCommand(int memberId, int trainerId)
        {
            MemberId = memberId;
            TrainerId = trainerId;
        }
    }
}
